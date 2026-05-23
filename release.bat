@echo off
dotnet build src/Limbo.SyntaxHighlighter --configuration Release /t:rebuild /t:pack -p:PackageOutputPath=../../releases/nuget