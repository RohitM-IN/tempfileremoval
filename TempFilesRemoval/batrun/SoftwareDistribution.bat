@echo off
net stop wuaserv 
net stop bits 
rename  %windir%\SoftwareDistribution SoftwareDistribution.old 
rd /s /q %windir%\SoftwareDistribution.old 
del /q /f /s "C:\Windows\SoftwareDistribution\*.*
net start wuaserv 
net start bits
echo x=msgbox("thank you for using our tool Note:-make sure that app is running as administator otherwise it will not work" ,0+64, "thank you") >> %temp%/msgbox.vbs

start %temp%/msgbox.vbs
TIMEOUT /T 1
cd %temp%
del /q/f/s msgbox.vbs
exit