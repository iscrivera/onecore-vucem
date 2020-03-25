FROM microsoft/dotnet:2.2-aspnetcore-runtime AS final
WORKDIR /app
COPY vucem-service/app/. /app/.
ENTRYPOINT ["dotnet", "Onecore.Vucem.Api.dll"]
