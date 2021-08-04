FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
COPY . App/
WORKDIR /App
RUN dotnet build
RUN dotnet publish -c DuzgunPublishFolder 
ENTRYPOINT ["dotnet", "bin/DuzgunPublishFolder/net5.0/publish/MyConsoleApp.dll"]

