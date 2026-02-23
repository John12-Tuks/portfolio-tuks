# Use the official .NET SDK image for building the project
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Copy project files and restore dependencies
COPY *.sln .
COPY cvPortfolio/*.csproj ./cvPortfolio/
RUN dotnet restore

# Copy all files and build the project
COPY . .
WORKDIR /app/cvPortfolio
RUN dotnet publish -c Release -o out

# Use the runtime image for deployment
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/cvPortfolio/out .

# Expose the default port
EXPOSE 80

# Set the entry point
ENTRYPOINT ["dotnet", "cvPortfolio.dll"]