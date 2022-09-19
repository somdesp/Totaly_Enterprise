#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/API Gateway/Totaly.BFF.Compras/Totaly.BFF.Compras.csproj", "src/API Gateway/Totaly.BFF.Compras/"]
RUN dotnet restore "src/API Gateway/Totaly.BFF.Compras/Totaly.BFF.Compras.csproj"
COPY . .
WORKDIR "/src/src/API Gateway/Totaly.BFF.Compras"
RUN dotnet build "Totaly.BFF.Compras.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Totaly.BFF.Compras.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Totaly.BFF.Compras.dll"]