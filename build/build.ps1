param(
	[Parameter(Mandatory=$true)][string]$version
)

$baseDir = "$PSScriptRoot\.."
$sourceDir = "$baseDir\src"
$solutionPath = "$sourceDir\Mikebm.TestLibrary.sln"

dotnet build $solutionPath --configuration Release /p:Version=$version
dotnet test $solutionPath --configuration Release --no-restore --no-build
