FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /app
COPY *.sln .
COPY src/DevOpsChallenge.SalesApi/*.csproj ./src/DevOpsChallenge.SalesApi/
COPY src/DevOpsChallenge.SalesApi.Business/*.csproj ./src/DevOpsChallenge.SalesApi.Business/
COPY src/DevOpsChallenge.SalesApi.Database/*.csproj ./src/DevOpsChallenge.SalesApi.Database/ 
COPY tests/DevOpsChallenge.SalesApi.Business.UnitTests/*.csproj ./tests/DevOpsChallenge.SalesApi.Business.UnitTests/ 
COPY tests/DevOpsChallenge.SalesApi.IntegrationTests/*.csproj ./tests/DevOpsChallenge.SalesApi.IntegrationTests/ 

#perform package restore
RUN dotnet restore ./src/DevOpsChallenge.SalesApi/DevOpsChallenge.SalesApi.csproj
RUN dotnet restore ./src/DevOpsChallenge.SalesApi.Database/DevOpsChallenge.SalesApi.Database.csproj
RUN dotnet restore ./tests/DevOpsChallenge.SalesApi.Business.UnitTests/DevOpsChallenge.SalesApi.Business.UnitTests.csproj

# copy full solution over
COPY . .
 

#perform builds 
RUN dotnet build ./src/DevOpsChallenge.SalesApi/DevOpsChallenge.SalesApi.csproj -c Release
RUN dotnet build ./tests/DevOpsChallenge.SalesApi.Business.UnitTests/DevOpsChallenge.SalesApi.Business.UnitTests.csproj
 
# run the unit tests 
RUN dotnet test ./tests/DevOpsChallenge.SalesApi.Business.UnitTests --logger:trx --results-directory /var/temp
 
# publish the API
FROM build AS publish
WORKDIR /app/src/DevOpsChallenge.SalesApi
RUN dotnet publish -c Release -o out

# run the api
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS runtime
WORKDIR /app
COPY --from=publish /app/src/DevOpsChallenge.SalesApi/out ./
EXPOSE 80
ENTRYPOINT ["dotnet", "DevOpsChallenge.SalesApi.dll"]