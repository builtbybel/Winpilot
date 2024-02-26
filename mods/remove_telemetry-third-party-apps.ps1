###This is a plugin template which will block and disable telemetry features of the following apps: ###
###- Block Google Chrome Software Reporter Tool
# The Software Reporter Tool (also known as Chrome Cleanup Tool and Software Removal Tool, the executable file is software_reporter_tool.exe), is a tool that Google distributes with the Google Chrome web browser. 
# It is a part of Google Chrome's Clean up Computer feature which scans your computer for harmful software. If this tool finds any harmful app or extension which can cause problems, it removes them from your computer. 
# Anything that interferes with a user's browsing experience may be removed by the tool.
# Its disadvantages, high CPU load or privacy implications, may be reason enough to block it from running. This script will disable the software_reporter_tool.exe in a more cleaner way using Image File Execution Options Debugger value. 
# Setting this value to an executable designed to kill processes disables it. Chrome won't re-enable it with almost each update. Next to this, it will also be disabled per default in Registry.
New-ItemProperty -Path "HKLM:\SOFTWARE\Policies\Google\Chrome" -Name ChromeCleanupEnabled -Type String -Value 0 -Force
New-ItemProperty -Path "HKLM:\SOFTWARE\Policies\Google\Chrome" -Name ChromeCleanupReportingEnabled -Type String -Value 0 -Force
New-ItemProperty -Path "HKLM:\SOFTWARE\Policies\Google\Chrome" -Name MetricsReportingEnabled -Type String -Value 0 -Force
# This will disable the software_reporter_tool.exe in a more cleaner way using Image File Execution Options Debugger value. 
# Setting this value to an executable designed to kill processes disables it. Chrome won't re-enable it with almost each update. 
If (!(Test-Path "HKLM:\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\software_reporter_tool.exe")) {
New-Item -Path "HKLM:\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\software_reporter_tool.exe" -Force | Out-Null
Write-Output "Google Chrome Software Reporter Tool has been successfully blocked."
}
Set-ItemProperty -Path "HKLM:\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\software_reporter_tool.exe" -Name "Debugger" -Type String -Value %windir%\System32\taskkill.exe -Force 

###- Disable Mozilla Firefox telemetry
# Firefox 75 comes with a new telemetry agent that sends information about your operating system and your default browser to Firefox every day. 
# The information collected is sent as a background telemetry ping every 24 hours to Mozilla.
# Mozilla has introduced a Windows group policy that prevents the default-browser-agent.exe executable from sending your default browser info. 
New-ItemProperty -Path "HKLM:\SOFTWARE\Policies\Mozilla\Firefox" -Name DisableTelemetry -Type DWord -Value 1 -Force
New-ItemProperty -Path "HKLM:\SOFTWARE\Policies\Mozilla\Firefox" -Name DisableDefaultBrowserAgent -Type DWord -Value 1 -Force

###- Disable CCleaner Monitoring
# Since Avast acquired Piriform, the popular system cleaning software CCleaner has become bloated with malware, bundled PUPs(potentially unwanted programs), and an alarming amount of pop-up ads.
# If you're highly dependent on CCleaner you can disable with this script the CCleaner Active Monitoring ("Active Monitoring" feature has been renamed with v5.46 to "Smart Cleaning"), 
# automatic Update check and download function, trial offer notifications, the new integrated Software Updater and the privacy option to "Help Improve CCleaner by sending anonymous usage data".
Stop-Process -name CCleaner*
New-ItemProperty -Path "HKCU:\Software\Piriform\CCleaner" -Name Monitoring -Type String -Value 0 -Force
New-ItemProperty -Path "HKCU:\Software\Piriform\CCleaner" -Name HelpImproveCCleaner -Type String -Value 0 -Force
New-ItemProperty -Path "HKCU:\Software\Piriform\CCleaner" -Name SystemMonitoring -Type String -Value 0 -Force
New-ItemProperty -Path "HKCU:\Software\Piriform\CCleaner" -Name UpdateAuto -Type String -Value 0 -Force
New-ItemProperty -Path "HKCU:\Software\Piriform\CCleaner" -Name UpdateCheck -Type String -Value 0 -Force
New-ItemProperty -Path "HKCU:\Software\Piriform\CCleaner" -Name CheckTrialOffer -Type String -Value 0 -Force
New-ItemProperty -Path "HKLM:\Software\Piriform\CCleaner" -Name (Cfg)GetIpmForTrial -Type String -Value 0 -Force
New-ItemProperty -Path "HKLM:\Software\Piriform\CCleaner" -Name (Cfg)SoftwareUpdater -Type String -Value 0 -Force
New-ItemProperty -Path "HKLM:\Software\Piriform\CCleaner" -Name (Cfg)SoftwareUpdaterIpm -Type String -Value 0 -Force
Get-ScheduledTask -TaskName "CCleaner Update" | Disable-ScheduledTask

###- Disable Dropbox Update service
# This will disable Dropbox auto update service
Get-ScheduledTask -TaskName "DropboxUpdateTaskMachineCore" | Disable-ScheduledTask
Get-ScheduledTask -TaskName "DropboxUpdateTaskMachineUA" | Disable-ScheduledTask

###- Disable Google Update service
# This will disable Google update service
Get-ScheduledTask -TaskName "GoogleUpdateTaskMachineCore" | Disable-ScheduledTask
Get-ScheduledTask -TaskName "GoogleUpdateTaskMachineUA" | Disable-ScheduledTask

###- Disable Media Player telemetry
# This will disable Media Player telemetry
New-ItemProperty -Path "HKCU:\SOFTWARE\Microsoft\MediaPlayer\Preferences" -Name UsageTracking -Type DWord -Value 0 -Force
New-ItemProperty -Path "HKCU:\Software\Policies\Microsoft\WindowsMediaPlayer" -Name PreventCDDVDMetadataRetrieval -Type DWord -Value 1 -Force
New-ItemProperty -Path "HKCU:\Software\Policies\Microsoft\WindowsMediaPlayer" -Name PreventMusicFileMetadataRetrieval -Type DWord -Value 1 -Force
New-ItemProperty -Path "HKCU:\Software\Policies\Microsoft\WindowsMediaPlayer" -Name PreventRadioPresetsRetrieval -Type DWord -Value 0 -Force
New-ItemProperty -Path "HKLM:\SOFTWARE\Policies\Microsoft\WMDRM" -Name DisableOnline -Type DWord -Value 1 -Force
Set-Service WMPNetworkSvc -StartupType Disabled

###- Disable Microsoft Office telemetry
# This will disable Microsoft Office telemetry (supports Microsoft Office 2013 and 2016)
Get-ScheduledTask -TaskName "OfficeTelemetryAgentFallBack2016" | Disable-ScheduledTask
Get-ScheduledTask -TaskName "OfficeTelemetryAgentLogOn2016" | Disable-ScheduledTask
New-ItemProperty -Path "HKCU:\SOFTWARE\Policies\Microsoft\Office\15.0\osm" -Name Enablelogging -Type DWord -Value 0 -Force
New-ItemProperty -Path "HKCU:\SOFTWARE\Policies\Microsoft\Office\15.0\osm" -Name EnableUpload -Type DWord -Value 0 -Force
New-ItemProperty -Path "HKCU:\SOFTWARE\Policies\Microsoft\Office\16.0\osm" -Name Enablelogging -Type DWord -Value 0 -Force
New-ItemProperty -Path "HKCU:\SOFTWARE\Policies\Microsoft\Office\16.0\osm" -Name EnableUpload -Type DWord -Value 0 -Force
