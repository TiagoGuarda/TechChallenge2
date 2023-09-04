#syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /App

# Copy *.sln and *.csproj
COPY *.sln .
COPY Blog.API.Autenticacao/*.csproj ./Blog.API.Autenticacao/
COPY Blog.API.Data/*.csproj ./Blog.API.Data/

# Restore as distinct layers
RUN dotnet restore

# Copy everything else
COPY Blog.API.Autenticacao/. ./Blog.API.Autenticacao/
COPY Blog.API.Data/. ./Blog.API.Data/

# Build and publish a release
WORKDIR /App/Blog.API.Autenticacao
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /App
COPY --from=build-env /App/Blog.API.Autenticacao/out ./
ENTRYPOINT ["dotnet", "Blog.API.Autenticacao.dll"]
