Option Explicit
Dim wshShell, Shortcut
Dim strDir, strName,currentDir,desktopDir
currentDir = createobject("Scripting.FileSystemObject").GetFolder(".").Path
strDir = currentDir
strName = "�������ܳ�������ϵͳ"
 
Set wshShell = WSH.CreateObject("WScript.Shell")
   desktopDir = wshShell.SpecialFolders("Desktop")
  Set Shortcut = wshShell.CreateShortcut(desktopDir &_
    "\" & strName & ".lnk")
    Shortcut.TargetPath = currentDir & "\CPTT.WinUI.exe" 
    Shortcut.WindowStyle = 1
    Shortcut.Hotkey = "CTRL+ALT+U"
    Shortcut.Description = "����������ʾ����������"
    Shortcut.WorkingDirectory = strDir
    Shortcut.Save
  Set Shortcut = Nothing
Set wshShell = Nothing
