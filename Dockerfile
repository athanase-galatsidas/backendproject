FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT=Development
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["backendproject.csproj", "./"]
RUN dotnet restore "backendproject.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "backendproject.csproj" -c Release -o /app/build 

FROM build AS publish
RUN dotnet publish "backendproject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "backendproject.dll"]
