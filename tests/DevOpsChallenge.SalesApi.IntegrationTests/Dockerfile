FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /app 

WORKDIR /tests
COPY ["tests/DevOpsChallenge.SalesApi.IntegrationTests/DevOpsChallenge.SalesApi.IntegrationTests.csproj", "tests/DevOpsChallenge.SalesApi.IntegrationTests/"]
COPY src/DevOpsChallenge.SalesApi/*.csproj ./src/DevOpsChallenge.SalesApi/
COPY src/DevOpsChallenge.SalesApi.Business/*.csproj ./src/DevOpsChallenge.SalesApi.Business/
COPY src/DevOpsChallenge.SalesApi.Database/*.csproj ./src/DevOpsChallenge.SalesApi.Database/ 

RUN dotnet restore "tests/DevOpsChallenge.SalesApi.IntegrationTests/DevOpsChallenge.SalesApi.IntegrationTests.csproj"

COPY . .  
 
WORKDIR "/tests/tests/DevOpsChallenge.SalesApi.IntegrationTests" 
 
CMD ["./wait-for-it.sh","db:1433","--timeout=10","--","dotnet","test"]

 
