@echo off
dotnet build src/Limbo.Umbraco.Time --configuration Release /t:rebuild /t:pack -p:PackageOutputPath=../../releases/nuget