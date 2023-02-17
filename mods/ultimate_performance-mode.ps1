[reflection.assembly]::loadwithpartialname("System.Windows.Forms") | Out-Null 
$msgBoxInput = [System.Windows.Forms.MessageBox]::Show('Do you want to enable the Ultimate Performance power plan?','Tweakomatic','YesNo','Question')

switch  ($msgBoxInput) {

  'Yes' {
  
powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61 

[System.Windows.Forms.MessageBox]::Show('Power plan has been successfully enabled. Now open Settings and navigate to System > Power & sleep > Additional Power Settings and enable the Ultimate Performance power plan.')
 }

'No'{}

}
