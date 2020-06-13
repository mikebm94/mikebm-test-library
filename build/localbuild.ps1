Start-Transcript ($PSScriptRoot + '\Temp\localbuild-log.txt')

$version = Get-Content "$PSScriptRoot\version.json" | Out-String | ConvertFrom-Json
& $PSScriptRoot\build.ps1 -version "$($version.Major).$($version.Minor).$($version.Patch)"

Stop-Transcript
