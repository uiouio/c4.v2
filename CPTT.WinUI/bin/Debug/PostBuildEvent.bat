@echo off
copy "E:\PROJECT\CTTPro\第四代智能晨检系统\CPTT.WinUI\*.config" E:\PROJECT\CTTPro\第四代智能晨检系统\CPTT.WinUI\bin\Debug\
if errorlevel 1 goto CSharpReportError
goto CSharpEnd
:CSharpReportError
echo Project error: 某个工具从生成事件中返回了错误代码
exit 1
:CSharpEnd