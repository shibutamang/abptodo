#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."] 
COPY ["src/abptodo.HttpApi.Host/abptodo.HttpApi.Host.csproj", "./abptodo.HttpApi.Host/"]
COPY ["src/abptodo.EntityFrameworkCore/abptodo.EntityFrameworkCore.csproj", "./src/abptodo.EntityFrameworkCore/"]
COPY ["src/abptodo.Domain/abptodo.Domain.csproj", "./src/abptodo.Domain/"]
COPY ["src/abptodo.Domain.Shared/abptodo.Domain.Shared.csproj", "./src/abptodo.Domain.Shared/"]
COPY ["src/abptodo.Application/abptodo.Application.csproj", "./src/abptodo.Application/"]
COPY ["src/abptodo.Application.Contracts/abptodo.Application.Contracts.csproj", "./src/abptodo.Application.Contracts/"]
#COPY ["src/abptodo.HttpApi/abptodo.HttpApi.csproj", "abptodo.HttpApi/"]
RUN dotnet restore "./src/abptodo.HttpApi.Host/abptodo.HttpApi.Host.csproj"
COPY . .
WORKDIR "src/abptodo.HttpApi.Host"
#RUN dotnet build "abptodo.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "abptodo.HttpApi.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "abptodo.HttpApi.Host.dll"]