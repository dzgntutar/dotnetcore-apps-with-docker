FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
COPY . App/
WORKDIR /App
RUN dotnet build
RUN dotnet restore
WORKDIR /App/ABC.Api
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "./out/ABC.Api.dll"]