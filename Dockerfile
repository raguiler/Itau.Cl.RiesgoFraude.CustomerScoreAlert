#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 8737
ENV ASPNETCORE_URLS="http://+:8737"
ENV ASPNETCORE_ENVIRONMENT="Development"
ENV Logging.LogLevel.Default="Information"
ENV ClientIdApicGw="4cfc526c5b05f098694e08452eb13873"
ENV ClientSecretApicGw="a9207314279d8640f0b4124296271893"
ENV ApiKeyDatamart="PVAq2OqIkSEkwECk9iSmvyUyI6WlIuUy10UAW70ATmE9cW5a8ZDduA=="
ENV BasePathApiGw="https://gw.dev.apis.itauchile.cl/inner/providers/datamart-customer-relationship-management/v1/"


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Itau.Cl.RF.CustomerScoreAlert.Api/Itau.Cl.RF.CustomerScoreAlert.API.csproj", "Itau.Cl.RF.CustomerScoreAlert.Api/"]
COPY ["Itau.Cl.RF.CustomerScoreAlert.Bll/Itau.Cl.Rf.CustomerScoreAlert.Bll.csproj", "Itau.Cl.RF.CustomerScoreAlert.Bll/"]
COPY ["Itau.Cl.RF.CustomerScoreAlert.Domain/Itau.Cl.RF.CustomerScoreAlert.Domain.csproj", "Itau.Cl.RF.CustomerScoreAlert.Domain/"]
COPY ["Itau.Cl.RF.CustomerScoreAlert.Infra/Itau.Cl.RF.CustomerScoreAlert.Infra.csproj", "Itau.Cl.RF.CustomerScoreAlert.Infra/"]
RUN dotnet restore "Itau.Cl.RF.CustomerScoreAlert.Api/Itau.Cl.RF.CustomerScoreAlert.API.csproj"
COPY . .
WORKDIR "/src/Itau.Cl.RF.CustomerScoreAlert.Api"
RUN dotnet build "Itau.Cl.RF.CustomerScoreAlert.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Itau.Cl.RF.CustomerScoreAlert.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Itau.Cl.RF.CustomerScoreAlert.API.dll"]