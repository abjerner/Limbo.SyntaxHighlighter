@echo off
dotnet build src/Limbo.SyntaxHighlighter --configuration Debug /t:rebuild /t:pack -p:PackageOutputPath=c:/nuget