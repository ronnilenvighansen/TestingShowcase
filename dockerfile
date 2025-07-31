FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /src
COPY . .

RUN dotnet restore
RUN dotnet build --configuration Release --no-restore

RUN dotnet test --configuration Release --no-build --collect:"XPlat Code Coverage"