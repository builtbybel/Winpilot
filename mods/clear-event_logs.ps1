Import-Module Microsoft.PowerShell.Management
Get-EventLog -LogName * | ForEach { Clear-EventLog $_.Log }