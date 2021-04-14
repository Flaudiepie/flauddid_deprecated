#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build
RUN apk --update add nodejs npm
WORKDIR /src
COPY ["Flauddid/Server/Flauddid.Server.csproj", "Flauddid/Server/"]
COPY ["Flauddid/Client/Flauddid.Client.csproj", "Flauddid/Client/"]
COPY ["Flauddid.Client.DataAccess/Flauddid.Client.DataAccess.csproj", "Flauddid.Client.DataAccess/"]
COPY ["Flauddid/Shared/Flauddid.Domain.csproj", "Flauddid/Shared/"]
COPY ["Flauddid.Server.DataAccess/Flauddid.Server.DataAccess.csproj", "Flauddid.Server.DataAccess/"]
RUN dotnet restore "Flauddid/Server/Flauddid.Server.csproj"
COPY . .
WORKDIR "/src/Flauddid/Server"
RUN dotnet build "Flauddid.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Flauddid.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Flauddid.Server.dll"]