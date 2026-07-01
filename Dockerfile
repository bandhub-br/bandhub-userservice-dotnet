FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["BandHub.UserService/BandHub.UserService.csproj", "BandHub.UserService/"]
RUN dotnet restore "BandHub.UserService/BandHub.UserService.csproj"
COPY . .
WORKDIR "/src/BandHub.UserService"
RUN dotnet build "BandHub.UserService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BandHub.UserService.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BandHub.UserService.dll"]
