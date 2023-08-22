@echo off
call PowerShell.exe -ExecutionPolicy Bypass -File "cleanup-csproj.ps1" -csprojPath "SwRebellionEditor.csproj"
pause