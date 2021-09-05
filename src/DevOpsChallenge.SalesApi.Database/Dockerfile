FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
  
WORKDIR /src
COPY ["src/DevOpsChallenge.SalesApi.Database/DevOpsChallenge.SalesApi.Database.csproj", "src/DevOpsChallenge.SalesApi.Database/"]
COPY src/DevOpsChallenge.SalesApi.Database/Setup.sh src/DevOpsChallenge.SalesApi.Database/Setup.sh



ENV PATH $PATH:/root/.dotnet/tools
RUN dotnet tool install -g dotnet-ef 
RUN dotnet restore "src/DevOpsChallenge.SalesApi.Database/DevOpsChallenge.SalesApi.Database.csproj"
COPY . .

#build to generate tables in modelcreation
RUN dotnet build "src/DevOpsChallenge.SalesApi.Database/DevOpsChallenge.SalesApi.Database.csproj"

WORKDIR "/src/src/DevOpsChallenge.SalesApi.Database"
 

EXPOSE 80/tcp
RUN chmod +x /src/src/DevOpsChallenge.SalesApi.Database/Setup.sh
CMD /bin/bash /src/src/DevOpsChallenge.SalesApi.Database/Setup.sh
 




 
