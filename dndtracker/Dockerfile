FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app
EXPOSE 80/tcp

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["dndtracker.csproj", "./"]
RUN dotnet restore "dndtracker.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "dndtracker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dndtracker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dndtracker.dll"]
