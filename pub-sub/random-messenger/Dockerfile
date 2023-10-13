FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["RandomMessenger.csproj", "./"]
RUN dotnet restore "RandomMessenger.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "RandomMessenger.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RandomMessenger.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RandomMessenger.dll"]
