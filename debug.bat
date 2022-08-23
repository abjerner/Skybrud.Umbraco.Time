@echo off
dotnet build src/Limbo.Umbraco.Time --configuration Debug /t:rebuild /t:pack -p:PackageOutputPath=c:/nuget