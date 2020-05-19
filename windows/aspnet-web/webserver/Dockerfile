FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /root/
ADD ./aspnetcoreapp/ ./aspnetcoreapp/
WORKDIR /root/aspnetcoreapp

RUN dotnet restore
RUN dotnet build

EXPOSE 5000/tcp 

ENTRYPOINT ["dotnet", "run", "--server.urls", "http://0.0.0.0:5000"]

