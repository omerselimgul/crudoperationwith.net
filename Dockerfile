FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OpenAPI/OpenAPI.csproj", "OpenAPI/"]
RUN dotnet restore "OpenAPI/OpenAPI.csproj"
COPY . .
WORKDIR "/src/OpenAPI"
RUN dotnet build "OpenAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OpenAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OpenAPI.dll"]