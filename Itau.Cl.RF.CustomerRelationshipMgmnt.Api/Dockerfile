#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 8737
ENV ASPNETCORE_ENVIRONMENT="Production"
ENV Logging.LogLevel.Default="Information"
#ENV ASPNETCORE_URLS="http://+:8737"

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Itau.Cl.ProjectName.Bff.TemplateLambda.csproj", "."]
RUN dotnet restore "./Itau.Cl.ProjectName.Bff.TemplateLambda.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Itau.Cl.ProjectName.Bff.TemplateLambda.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Itau.Cl.ProjectName.Bff.TemplateLambda.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Itau.Cl.ProjectName.Bff.TemplateLambda.dll"]