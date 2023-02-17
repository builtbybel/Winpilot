###Certain elements of Windows 11, such as the News and interests widget, open links in Edge regardless of which browser is set as default. This is done through the use of edge:// protocol links. ###
###This script intercepts URIs that force-open web links in Microsoft Edge and redirects it to the system's default web browser ###
###To revert to Edge as the default handler for web searches, all you have to do is run the script again. ###
###Projects page: https://github.com/AveYo/fox/blob/main/ChrEdgeFkOff.cmd
@(set "0=%~f0"^)#) & powershell -nop -c iex([io.file]::ReadAllText($env:0)) & exit/b
#:: double-click to run or just copy-paste into powershell - it's a standalone hybrid script
#::
#:: ChrEdgeFkOff - make start menu web search or widgets links open in your chosen default browser - by AveYo
#:: v2.0 only redirects microsoft-edge: links, no longer blocks msedge.exe (with a junction trick)    
#:: 
$_Paste_in_Powershell = {
$vbs = @'
' ChrEdgeFkOff - make start menu web search or widgets links open in your chosen default browser - by AveYo  
Dim C, A: For Each i in WScript.Arguments: A = A&" """&i&"""": Next
Set W = CreateObject("WScript.Shell"): Set E = W.Environment( "Process" ): E("CL") = A : C = ""
C = C & "$U = get-itemproperty 'HKCU:\SOFTWARE\Microsoft\Windows\Shell\Associations\UrlAssociations\https\UserChoice' 'ProgID';"
C = C & "$C = get-itemproperty -lit $('Registry::HKCR\' + $U.ProgID + '\shell\open\command') '(Default)' -ea 0;"
C = C & "$UserChoice = ($C.'(Default)'-split [char]34,3)[1]; $MSE = $env:CL -replace '\\Microsoft\\Edge', '\Microsoft\ChrEdge';"
C = C & "if ($UserChoice -like '*Microsoft\Edge\Application\msedge.exe*') {iex('&'+$MSE); return 2};"
C = C & "if ($env:CL -notlike '*microsoft-edge:*') {iex('&'+$MSE); return 1};"
C = C & "start $UserChoice $([uri]::unescapedatastring(($env:CL-split'(?=http[s]?)')[1] -replace [char]34)+' '); return 0"
W.Run "powershell -nop -c " & C, 0, False
'@ 
$DATA = [Environment]::GetFolderPath('CommonApplicationData'); $file = join-path $DATA "ChrEdgeFkOff.vbs"
$PROF = [Environment]::GetFolderPath('ProgramFiles'+('x86','')[![Environment]::Is64BitOperatingSystem])
$EDGE = join-path $PROF 'Microsoft\Edge\'; $CREDGE = join-path $PROF 'Microsoft\ChrEdge\'
$IFEO = 'HKLM:\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\msedge.exe'
if (test-path "$IFEO\0") {
  remove-item "$IFEO\0" -rec -force -ea 0 >''; remove-itemproperty $IFEO 'Debugger' -force -ea 0 >'' 
  del $file -force -ea 0 >''; rmdir $CREDGE -rec -force -ea 0 >'';
  write-host -fore 0xf -back 0xd "`n ChrEdgeFkOff v2.0 [REMOVED] run again to install "
} else {                              
  new-item "$IFEO\0" -force -ea 0 >''; remove-itemproperty $IFEO 'Debugger' -force -ea 0 >'' 
  [io.file]::WriteAllText($file, $vbs) >''; start -nonew cmd "/d/x/r mklink /J ""$CREDGE"" ""$EDGE"" >nul"
  set-itemproperty $IFEO 'UseFilter' 1 -type dword -force -ea 0
  set-itemproperty "$IFEO\0" 'FilterFullPath' $(join-path $PROF 'Microsoft\Edge\Application\msedge.exe') -force -ea 0 
  set-itemproperty "$IFEO\0" 'Debugger' "wscript $file //B //T:5" -force -ea 0 
  write-host -fore 0xf -back 0x2 "`n ChrEdgeFkOff v2.0 [INSTALLED] run again to remove " } ; timeout /t 5
} ; start -verb runas powershell -args "-nop -c & {`n`n$($_Paste_in_Powershell-replace'"','\"')}"
$_Press_Enter
#::
