FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
COPY . App/
WORKDIR /App
ENV ASPNETCORE_URLS=http://+:80  
EXPOSE 80
RUN dotnet restore
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "./out/2-ApiApp.dll"]
