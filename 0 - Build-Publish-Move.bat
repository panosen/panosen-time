@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.Time\bin\Release\Panosen.Time.*.nupkg D:\LocalSavoryNuget\

pause