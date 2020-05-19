# Docker example

Documentation at [link]: https://dotnet.microsoft.com/learn/aspnet/microservice-tutorial/intro

## First
dotnet run // for run at localhost the service

## Second
docker build -t mymicroservice .   // Create the image

## Third
docker run -it --rm -p 3000:80 --name mymicroservicecontainer mymicroservice // Run Image

// http://localhost:3000/WeatherForecast you can access this rout to api test

docker ps // list images running

