FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
COPY . App/
WORKDIR /App
RUN dotnet restore
WORKDIR /App/ABC.Service
ENV ASPNETCORE_URLS=http://+:80  
EXPOSE 80
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "./out/ABC.Service.dll"]