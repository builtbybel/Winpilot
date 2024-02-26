# Read EdgeChromium Bookmarks (JSON File) and Export/Backup to HTML File
# Gunnar Haslinger, 30.10.2019 - tested width EdgeChromium Beta 78
# SCCMOG - Richie Schuster, 2022.02.08 - Tested with Edge Chromium 98.0.1108.43 - https://github.com/SCCMOG - SCCMOG.com

# Path to EdgeChromium Bookmarks File and HTML Export
$JSON_File_Path = "$($env:localappdata)\Microsoft\Edge\User Data\Profile 1\Bookmarks"
$ExportedTime = Get-Date -Format 'yyyy-MM-dd_HH.mm'
$HTML_File_Root = $DesktopPath = [Environment]::GetFolderPath("Desktop")
$HTML_File_Path = "$($HTML_File_Root)\EdgeChromium-Bookmarks.backup_$($ExportedTime).html"
# Reference-Timestamp needed to convert Timestamps of JSON (Milliseconds / Ticks since LDAP / NT epoch 01.01.1601 00:00:00 UTC) to Unix-Timestamp (Epoch)
$Date_LDAP_NT_EPOCH = Get-Date -Year 1601 -Month 1 -Day 1 -Hour 0 -Minute 0 -Second 0

if (!(Test-Path -Path $JSON_File_Path -PathType Leaf)) {
    throw "Source-File Path $JSON_File_Path does not exist!" 
}
if (!(Test-Path -Path $HTML_File_Root -PathType Container)) { 
    throw "Destination-Root Path $HTML_File_Root does not exist!" 
}

# ---- HTML Header ----
$BookmarksHTML_Header = @'
<!DOCTYPE NETSCAPE-Bookmark-file-1>
<!-- This is an automatically generated file.
     It will be read and overwritten.
     DO NOT EDIT! -->
<META HTTP-EQUIV="Content-Type" CONTENT="text/html; charset=UTF-8">
<TITLE>Bookmarks</TITLE>
<H1>Bookmarks</H1>
<DL><p>
'@

$BookmarksHTML_Header | Out-File -FilePath $HTML_File_Path -Force -Encoding utf8

# ---- Enumerate Bookmarks Folders ----
Function Get-BookmarkFolder {
    [cmdletbinding()] 
    Param( 
        [Parameter(Position = 0, ValueFromPipeline = $True)]
        $Node 
    )
    function ConvertTo-UnixTimeStamp {
        param(
            [Parameter(Position = 0, ValueFromPipeline = $True)]
            $TimeStamp 
        )
        $date = [Decimal] $TimeStamp
        if ($date -gt 0) { 
            $date = $Date_LDAP_NT_EPOCH.AddTicks($date * 10)
            $date = $date | Get-Date -UFormat %s 
            $unixTimeStamp = [int][double]::Parse($date) - 1
            return $unixTimeStamp
        }
    }   
    if ($node.name -like "Favorites Bar") {
        $DateAdded = [Decimal] $node.date_added | ConvertTo-UnixTimeStamp
        $DateModified = [Decimal] $node.date_modified | ConvertTo-UnixTimeStamp
        "        <DT><H3 FOLDED ADD_DATE=`"$($DateAdded)`" LAST_MODIFIED=`"$($DateModified)`" PERSONAL_TOOLBAR_FOLDER=`"true`">$($node.name )</H3>" | Out-File -FilePath $HTML_File_Path -Append -Force -Encoding utf8
        "        <DL><p>" | Out-File -FilePath $HTML_File_Path -Append -Force -Encoding utf8
    }
    foreach ($child in $node.children) {
        $DateAdded = [Decimal] $child.date_added | ConvertTo-UnixTimeStamp    
        $DateModified = [Decimal] $child.date_modified | ConvertTo-UnixTimeStamp
        if ($child.type -eq 'folder') {
            "        <DT><H3 ADD_DATE=`"$($DateAdded)`" LAST_MODIFIED=`"$($DateModified)`">$($child.name)</H3>" | Out-File -FilePath $HTML_File_Path -Append -Force -Encoding utf8
            "        <DL><p>" | Out-File -FilePath $HTML_File_Path -Append -Force -Encoding utf8
            Get-BookmarkFolder $child # Recursive call in case of Folders / SubFolders
            "        </DL><p>" | Out-File -FilePath $HTML_File_Path -Append -Force -Encoding utf8
        }
        else {
            # Type not Folder => URL
            "        <DT><A HREF=`"$($child.url)`" ADD_DATE=`"$($DateAdded)`">$($child.name)</A>" | Out-File -FilePath $HTML_File_Path -Append -Encoding utf8
        }
    }
    if ($node.name -like "Favorites Bar") {
        "        </DL><p>" | Out-File -FilePath $HTML_File_Path -Append -Force -Encoding utf8
    }
}

# ---- Convert the JSON Contens (recursive) ----
$data = Get-content $JSON_File_Path -Encoding UTF8 | out-string | ConvertFrom-Json
$sections = $data.roots.PSObject.Properties | Select-Object -ExpandProperty name
ForEach ($entry in $sections) { 
    $data.roots.$entry | Get-BookmarkFolder
}

# ---- HTML Footer ----
'</DL>' | Out-File -FilePath $HTML_File_Path -Append -Force -Encoding utf8