$version = Get-Content "$PSScriptRoot\version.json" | Out-String | ConvertFrom-Json
$versionString = "$($version.Major).$($version.Minor).$($version.Patch)"
Write-Host "##vso[task.setvariable variable=mylibver]$versionString"

& $PSScriptRoot\build.ps1 -version $versionString

