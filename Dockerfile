FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Kliutsuk.Bot/Kliutsuk.Bot.csproj", "Kliutsuk.Bot/"]
COPY ["Kliutsuk.Core/Kliutsuk.Core.csproj", "Kliutsuk.Core/"]
RUN dotnet restore "Kliutsuk.Bot/Kliutsuk.Bot.csproj"
COPY . .
WORKDIR "/src/Kliutsuk.Bot"
RUN dotnet build "Kliutsuk.Bot.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kliutsuk.Bot.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Kliutsuk.Bot.dll