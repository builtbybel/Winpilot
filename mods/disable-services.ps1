###- Connected User Experiences and Telemetry
###- FAX
###- AllJoyn Router Service
###- Program Compatibility Assistant Service
###- Device Management Wireless Application Protocol (WAP) Push message Routing Service
###- Remote Registry
###- Windows Media Player Network Sharing Service
###- Windows Image Acquisition
###- Xbox Services
###- Windows Network Data Usage Monitor###

$services = @(
    "DiagTrack"                                # Connected User Experiences and Telemetry. If you're concerned with privacy and don't want to send usage data to Microsoft for analysis, then this service is one to go.
	"fxssvc.exe"				               # Fax. As its name suggests, this is a service needed only if you want to send and receive faxes.
    "AxInstSV"								   # AllJoyn Router Service. This is a service that lets you connect Windows to the Internet of Things and communicate with devices such as smart TVs, refrigerators, light bulbs, thermostats, etc.
    "PcaSvc"                                   # Program Compatibility Assistant Service (Unless you're still using legacy software on your Windows 11 PC, you can easily turn off this service. This service lets you detect software incompatibility issues for old games and software. But if you're using programs and apps built for Window 11, go ahead and disable it.)
	"dmwappushservice"						   # Device Management Wireless Application Protocol (WAP) Push message Routing Service. This service is another service that helps to collect and send user data to Microsoft. Strengthen your privacy by disabling it, it is recommended that you do so. 
    "Remote Registry"                          # Remote Registry. This service lets any user access and modify the Windows registry. It is highly recommended that you disable this service for security purposes. Your ability to edit the registry locally (or as admin) won't be affected. 
    "WMPNetworkSvc"                            # Windows Media Player Network Sharing Service
    "StiSvc"                                   # Windows Image Acquisition. This service is important for people who connect scanners and digital cameras to their PC. But if you don't have one of those, or are never planning on getting one, disable it by all means.
    "XblAuthManager"                           # Xbox Live Auth Manager. If you don't use Xbox app to play games, then you don't need any of the Xbox services.
    "XblGameSave"                              # Xbox Live Game Save Service
    "XboxNetApiSvc"                            # Xbox Live Networking Service
    "ndu"                                      # Windows Network Data Usage Monitor
	#"wisvc"								   # Windows Insider Service. Disable this service only if you're not in the Windows Insider program. Currently, as Windows 11 is only available through it, you shouldn't disable it. 
)	

foreach ($service in $services) {
    Write-Output "Trying to disable $service"
    Get-Service -Name $service | Set-Service -StartupType Disabled
}