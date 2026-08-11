# CSharp MVC — Monolithic (net10.0)

ASP.NET Core MVC monolithic project for **net10** targeting **net10.0** (C# 14).

## Project type

- **Scenario:** 1 - Monolithic
- **Project type:** ASP.NET Core MVC / Razor Web Application
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

## Tool MSBuild targets

```bash
dotnet msbuild tools/CSharpMvc.Tools/CSharpMvc.Tools.csproj -t:RunCoverlet
dotnet msbuild tools/CSharpMvc.Tools/CSharpMvc.Tools.csproj -t:RunAltCover
```
