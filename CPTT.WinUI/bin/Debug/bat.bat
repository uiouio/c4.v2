@echo on
osql -E -i %~dp0scripts\sql.script
