#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$packDir = Join-Path $scriptDir "pack"
if (Test-Path $packDir) { Remove-Item -Recurse -Force $packDir }
Copy-Item -Recurse -Force (Join-Path $scriptDir "content" "GreenStack.Umbraco.StarterKit") $packDir
Copy-Item -Recurse -Force (Join-Path $scriptDir "template-config" ".template.config") (Join-Path $packDir ".template.config")
Write-Host "Pack directory assembled at: $packDir"
