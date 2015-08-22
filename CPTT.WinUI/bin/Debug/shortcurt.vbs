Option Explicit
Dim wshShell, Shortcut
Dim strDir, strName,currentDir,desktopDir
currentDir = createobject("Scripting.FileSystemObject").GetFolder(".").Path
strDir = currentDir
strName = "创智智能晨检网络系统"
 
Set wshShell = WSH.CreateObject("WScript.Shell")
   desktopDir = wshShell.SpecialFolders("Desktop")
  Set Shortcut = wshShell.CreateShortcut(desktopDir &_
    "\" & strName & ".lnk")
    Shortcut.TargetPath = currentDir & "\CPTT.WinUI.exe" 
    Shortcut.WindowStyle = 1
    Shortcut.Hotkey = "CTRL+ALT+U"
    Shortcut.Description = "这是命令提示符程序描述"
    Shortcut.WorkingDirectory = strDir
    Shortcut.Save
  Set Shortcut = Nothing
Set wshShell = Nothing
