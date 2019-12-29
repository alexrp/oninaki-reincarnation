#!/usr/bin/env pwsh

$ErrorActionPreference = "Stop"
Set-StrictMode -Version 2.0

foreach ($file in Get-ChildItem -Filter "*.md" -Recurse)
{
    $path = Resolve-Path $file -Relative

    Write-Output "Linting $path..."
    markdownlint $path
}

foreach ($file in Get-ChildItem -Filter "*.json" -Recurse)
{
    $path = Resolve-Path $file -Relative

    Write-Output "Linting $path..."
    jsonlint $path -q
}
