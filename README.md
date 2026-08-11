# CSharp MVC — Monolithic (net472)

ASP.NET MVC 5 monolithic project for **net4.7.2** targeting **net472** (C# 7.3).

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
