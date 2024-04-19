# Get all installed Windows apps for all users
$allApps = Get-AppxPackage -AllUsers

# Counter for tracking progress
$totalApps = $allApps.Count
$currentAppIndex = 1
$reinstalledCount = 0

# Loop through each app and reinstall
foreach ($app in $allApps) {
    # Display current status
    Write-Host "[$currentAppIndex / $totalApps] Reinstalling $($app.Name)..." -ForegroundColor Yellow

    # Try to reinstall the app
    try {
        Add-AppxPackage -Register "$($app.InstallLocation)\appxmanifest.xml" -DisableDevelopmentMode -ErrorAction Stop
        Write-Host "[$currentAppIndex / $totalApps] $($app.Name) reinstalled successfully." -ForegroundColor Green
        $reinstalledCount++
    } catch {
        Write-Host "[$currentAppIndex / $totalApps] Error occurred while reinstalling $($app.Name): $_" -ForegroundColor Red
    }

    # Increment the counter
    $currentAppIndex++
}

# Display final status
if ($reinstalledCount -eq $totalApps) {
    Write-Host "All apps reinstalled successfully." -ForegroundColor Green
    Write-Host "Winpilot and Clippy have reinstalled everything possible." -ForegroundColor Cyan
}
