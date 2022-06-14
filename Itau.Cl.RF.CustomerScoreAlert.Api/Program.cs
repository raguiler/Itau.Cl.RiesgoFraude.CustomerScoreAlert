using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Itau.Cl.RF.CustomerScoreAlert.Infra;
using Itau.Cl.RF.CustomerScoreAlert.Infra.Exceptions;

#region Builder

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = Assembly.GetCallingAssembly().GetName().Name, Version = "v1" });
});

/// <summary>
/// Logger builder configuration
/// </summary>
Action<ILoggingBuilder> _loggerBuilder = builder =>
{
    builder.AddFilter("Microsoft", LogLevel.Information)
        .AddFilter("System", LogLevel.Information)
        .AddFilter("Program", LogLevel.Information)
        .AddFilter("System.Net.Http.HttpClient", LogLevel.Information)
        .AddJsonConsole(o => { o.IncludeScopes = true; o.UseUtcTimestamp = true; });
};


builder.Services.AddHealthChecks();

builder.Services.AddLogging(_loggerBuilder);

/// <summary>
/// Configure behavior ModelState validation
/// </summary>
builder.Services.Configure((Action<ApiBehaviorOptions>)(optionsValidation =>
{
    optionsValidation.InvalidModelStateResponseFactory = actionContext =>
    {
        var error = string.Join(" | ", actionContext.ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
        var badRequest = new GenericError("400", error);
        return new BadRequestObjectResult(badRequest);
    };
}));


builder.Services.AddHttpClient();

/// <summary>
/// Add support to LambdaHosting https://aws.amazon.com/blogs/compute/introducing-the-net-6-runtime-for-aws-lambda/
/// </summary>
builder.Services.AddAWSLambdaHosting(LambdaEventSource.ApplicationLoadBalancer);

var app = builder.Build();

#endregion

#region Services

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", Assembly.GetCallingAssembly().GetName().Name);
    });
}

app.UseSwagger(c =>
{
    c.SerializeAsV2 = true;
});

app.UseExceptionHandler(
    options =>
    {
        options.Run(
        async context =>
        {
            context.Response.StatusCode = 500;
            context.Response.ContentType = "application/json";
            var ex = context.Features.Get<IExceptionHandlerFeature>();
            if (ex != null)
            {
                var error = JsonSerializer.Serialize(new GenericError("500", ex.Error.Message));
                await context.Response.WriteAsync(error).ConfigureAwait(false);
            }
        });
    }
   );

app.UseAuthorization();

app.MapControllers();

app.MapHealthChecks("/health", new HealthCheckOptions()
{
    ResultStatusCodes =
                        {
                            [HealthStatus.Healthy] = StatusCodes.Status200OK,
                            [HealthStatus.Degraded] = StatusCodes.Status200OK,
                            [HealthStatus.Unhealthy] = StatusCodes.Status503ServiceUnavailable
                        }
});

/// <summary>
/// Initialize EnvironmentVariables singleton
/// </summary>
var envVariables = Environment.GetEnvironmentVariables();
EnvironmentVariables.Init(envVariables, _loggerBuilder);


app.Run();
#endregion
