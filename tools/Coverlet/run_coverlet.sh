#!/usr/bin/env bash
set -euo pipefail
dotnet test ../../tests/CSharpMvc.Tests/CSharpMvc.Tests.csproj --collect:"XPlat Code Coverage"
