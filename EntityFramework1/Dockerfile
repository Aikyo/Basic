#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 63529
EXPOSE 44355

FROM microsoft/dotnet:2.1-sdk-nanoserver-sac2016 AS build
WORKDIR /src
COPY ["EntityFramework1/EntityFramework1.csproj", "EntityFramework1/"]
RUN dotnet restore "EntityFramework1/EntityFramework1.csproj"
COPY . .
WORKDIR "/src/EntityFramework1"
RUN dotnet build "EntityFramework1.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EntityFramework1.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EntityFramework1.dll"]