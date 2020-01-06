#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-nanoserver-1803 AS build
WORKDIR /src
COPY ["MyData.AccountService/MyData.AccountService.csproj", "MyData.AccountService/"]
COPY ["MyData.Db/MyData.Db.csproj", "MyData.Db/"]
RUN dotnet restore "MyData.AccountService/MyData.AccountService.csproj"
COPY . .
WORKDIR "/src/MyData.AccountService"
RUN dotnet build "MyData.AccountService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyData.AccountService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyData.AccountService.dll"]