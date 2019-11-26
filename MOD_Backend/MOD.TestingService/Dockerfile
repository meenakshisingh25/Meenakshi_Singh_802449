FROM mcr.microsoft.com/dotnet/core/runtime:3.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MOD.TestingService/MOD.TestingService.csproj", "MOD.TestingService/"]
COPY ["MOD.Technologyservice/MOD.Technologyservice.csproj", "MOD.Technologyservice/"]
RUN dotnet restore "MOD.TestingService/MOD.TestingService.csproj"
COPY . .
WORKDIR "/src/MOD.TestingService"
RUN dotnet build "MOD.TestingService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD.TestingService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD.TestingService.dll"]