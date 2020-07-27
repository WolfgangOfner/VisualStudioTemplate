FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["$ext_safeprojectname$.Api/$ext_safeprojectname$.Api.csproj", "$ext_safeprojectname$.Api/"]
COPY ["$ext_safeprojectname$.Service/$ext_safeprojectname$.Service.csproj", "$ext_safeprojectname$.Service/"]
COPY ["$ext_safeprojectname$.Data/$ext_safeprojectname$.Data.csproj", "$ext_safeprojectname$.Data/"]
RUN dotnet restore "$ext_safeprojectname$.Api/$ext_safeprojectname$.Api.csproj"
COPY . .
WORKDIR "/src/$ext_safeprojectname$.Api"
RUN dotnet build "$ext_safeprojectname$.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "$ext_safeprojectname$.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "$ext_safeprojectname$.Api.dll"]