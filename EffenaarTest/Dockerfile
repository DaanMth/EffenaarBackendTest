FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["EffenaarTest/EffenaarTest.csproj", "EffenaarTest/"]
RUN dotnet restore "EffenaarTest/EffenaarTest.csproj"
COPY . .
WORKDIR "/src/EffenaarTest"
RUN dotnet build "EffenaarTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EffenaarTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EffenaarTest.dll"]
