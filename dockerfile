FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build
WORKDIR p1/
COPY . destination
RUN dotnet build
RUN dotnet publish -c Release -o out MyPizza.Client/MyPizza.Client.csproj

#ENV ASPNETCORE_URLS="http://5000"

FROM mcr.microsoft,com/dotnet.core/aspnet:2.1
WORKDIR dist/
COPY --from=build p1/out ./
RUN ls

# CMD dotnet /out/MyPizza.Client.dll
# alternate way
CMD ["dotnet", "MyPizza.Client.dll"]