@echo off
copy "E:\PROJECT\CTTPro\���Ĵ����ܳ���ϵͳ\CPTT.WinUI\*.config" E:\PROJECT\CTTPro\���Ĵ����ܳ���ϵͳ\CPTT.WinUI\bin\Debug\
if errorlevel 1 goto CSharpReportError
goto CSharpEnd
:CSharpReportError
echo Project error: ĳ�����ߴ������¼��з����˴������
exit 1
:CSharpEnd