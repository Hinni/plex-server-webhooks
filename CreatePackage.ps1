
# Arrange
$directory = Split-Path $MyInvocation.MyCommand.Path

# Create NuGet Package
& $directory\packages\NuGet.CommandLine.4.1.0\tools\NuGet.exe pack $directory\Plex.Server.Webhooks\Plex.Server.Webhooks.csproj -OutputDirectory $directory -Prop Configuration=Release
