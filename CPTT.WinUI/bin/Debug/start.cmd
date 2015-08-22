@echo on
regsvr32 %~dp0/CtrlSerial.dll
osql -E -Q "exec sp_attach_db @dbname = N'CTPPDB',@filename1 = '%~dp0db\CTPPDB.mdf',@filename2 = '%~dp0db\CTPPDB_LOG.LDF'"
osql -E -i %~dp0scripts\sql.script
start %~dp0/shortcurt.vbs
start %~dp0/CPTT.WinUI.exe
