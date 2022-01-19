FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/ETF.Meido.WebApi/ETF.Meido.WebApi.csproj", "src/ETF.Meido.WebApi/"]
COPY ["src/ETF.Meido.Application.Services/ETF.Meido.Application.Services.csproj", "src/ETF.Meido.Application.Services/"]
COPY ["src/ETF.Meido.Application.Services.Contracts/ETF.Meido.Application.Services.Contracts.csproj", "src/ETF.Meido.Application.Services.Contracts/"]
COPY ["src/ETF.Meido.Domain.RepositoryContracts/ETF.Meido.Domain.RepositoryContracts.csproj", "src/ETF.Meido.Domain.RepositoryContracts/"]
COPY ["src/ETF.Meido.Domain.Entities/ETF.Meido.Domain.Entities.csproj", "src/ETF.Meido.Domain.Entities/"]
COPY ["src/ETF.Meido.Infrastructure.Repositories/ETF.Meido.Infrastructure.Repositories.csproj", "src/ETF.Meido.Infrastructure.Repositories/"]
COPY ["src/ETF.Meido.Infrastructure.ServiceAgents/ETF.Meido.Infrastructure.ServiceAgents.csproj", "src/ETF.Meido.Infrastructure.ServiceAgents/"]
COPY ["src/ETF.Meido.Infrastructure.ServiceAgents.Contracts/ETF.Meido.Infrastructure.ServiceAgents.Contracts.csproj", "src/ETF.Meido.Infrastructure.ServiceAgents.Contracts/"]
COPY ["src/ETF.Meido.CrossCutting.Error.Contracts/ETF.Meido.CrossCutting.Errors.Contracts.csproj", "src/ETF.Meido.CrossCutting.Error.Contracts/"]
COPY ["src/ETF.Meido.CrossCutting.Error.Implementation/ETF.Meido.CrossCutting.Errors.Implementation.csproj", "src/ETF.Meido.CrossCutting.Error.Implementation/"]
RUN dotnet restore "src/ETF.Meido.WebApi/ETF.Meido.WebApi.csproj"
COPY . .
WORKDIR "/src/src/ETF.Meido.WebApi"
RUN dotnet build "ETF.Meido.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ETF.Meido.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ETF.Meido.WebApi.dll"]