FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /
EXPOSE 80

#ENV ASPNETCORE_URLS=http://+:8000;http://+:80;


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Copy all in this root folder
COPY . /Identity

#Faz a navegação
WORKDIR /Identity

# Restore libraries
RUN dotnet restore Identity/InvesTrace.Identity.Api.csproj

# Build
RUN dotnet build Identity/InvesTrace.Identity.Api.csproj -c Release -o /build

#define o nome do step
FROM build AS publish

RUN dotnet publish Identity/InvesTrace.Identity.Api.csproj -c Release -o /publish

FROM runtime AS final
WORKDIR /publish

COPY --from=publish /publish .

ARG ENVIRONMENT
ENV ASPNETCORE_ENVIRONMENT $ENVIRONMENT
#ENTRYPOINT [ "dotnet", "InvesTrace.Identity.Api.dll" ]

# Usa porta dinâmica do Heroku
CMD ASPNETCORE_URLS="http://*:$PORT" dotnet InvesTrace.Identity.Api.dll

