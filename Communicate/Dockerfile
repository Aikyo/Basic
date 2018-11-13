#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 56658
EXPOSE 44365

FROM microsoft/dotnet:2.1-sdk-nanoserver-sac2016 AS build
WORKDIR /src
COPY ["Communicate/Communicate.csproj", "Communicate/"]
RUN dotnet restore "Communicate/Communicate.csproj"
COPY . .
WORKDIR "/src/Communicate"
RUN dotnet build "Communicate.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Communicate.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Communicate.dll"]