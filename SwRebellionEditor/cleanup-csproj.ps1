param(
    [string]$csprojPath
)

# Check if the provided path is a valid .csproj file
if (-not (Test-Path $csprojPath -PathType Leaf) -or [System.IO.Path]::GetExtension($csprojPath) -ne ".csproj") {
    Write-Host "Invalid .csproj file path."
    exit
}

# Load the .csproj XML content
$xml = [xml](Get-Content -Path $csprojPath)

$projectDirectory = [System.IO.Path]::GetDirectoryName($csprojPath)

# Iterate through all the <ItemGroup> elements containing <None> references
foreach ($itemGroup in $xml.Project.ItemGroup) {
    $itemsToRemove = @()

    foreach ($item in $itemGroup.ChildNodes) {
        if ($item.Name -eq "None" -and $item.Update) {
            $filePath = [System.IO.Path]::Combine($projectDirectory, $item.Update)
            if (-not (Test-Path $filePath)) {
                $itemsToRemove += $item
            }
        }
    }

    foreach ($itemToRemove in $itemsToRemove) {
        $itemGroup.RemoveChild($itemToRemove)
    }
}

# Save the modified .csproj file
$xml.Save($csprojPath)

Write-Host "Unused references removed from $csprojPath."