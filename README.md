# CSharp MVC — Monolithic (net48)

ASP.NET MVC 5 monolithic project for **net48** targeting **net48** (C# 8).

## Project type

- **Scenario:** 1 - Monolithic
- **Project type:** ASP.NET MVC 5 (.NET Framework)
- **Language:** C#

## Supported tools

- AltCover
- Coverlet
- NuGet-Audit
- OpenTelemetry
- Roslyn
- Semgrep
- Stryker.NET
- jscpd
- lizard
- pydriller
- roslyn-sast

## Build

```bash
dotnet restore CSharpMvc.sln
dotnet build CSharpMvc.sln
dotnet test CSharpMvc.sln
dotnet run --project src/CSharpMvc/CSharpMvc.csproj
```
