@echo off &setlocal
title Temp Files Removal
:choice
:: create a backspace character
for /f %%i in ('"prompt $H &for %%b in (1) do rem"') do set "bs=%%i"

:: animate the string
for %%i in (
  N O T E ":-" " " T h i s " " " " m a y " " " " t a k e " " " " s o m e " " " " t i m e " " " " o r " " " " e v e n " " " " h o u r s " " " " o n " " " " f i r s t " " " " r u n " " " " a l s o  " " " " e v e r y  " " " " t h i n g  " " " " i n  " " " " r e c y c l e  " " " " b i n  " " " " w i l l  " " " "  b e  " " " " r e m o v e d "." " 
) do (<nul set /p "=.%bs%%%~i" & >nul ping -n 1.5 localhost)

:: add a line break
echo(
TIMEOUT /T 5
title Temp Files Removal
set /P c=Are you sure you want to continue deleting your tmp files including recycle bin[Y/N]?
if /I "%c%" EQU "Y" goto :somewhere
if /I "%c%" EQU "N" goto :somewhere_else
goto :choice
:somewhere
echo turn off your internet brouser press y when asked if no then close this window
takeown "%userprofile%\AppData\Local\Temporary Internet Files"
del /q/f/s "%userprofile%\AppData\Local\Temporary Internet Files\*"
RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 2
del /q/f/s %TEMP%\*.*
del /q/f/s "C:\Windows\Temp\*.*"
del /q/f/s "C:\Temp\*.*"
net stop wuaserv 
net stop bits 
rename  %windir%\SoftwareDistribution SoftwareDistribution.old 
rd /s /q %windir%\SoftwareDistribution.old 
del /q /f /s "C:\Windows\SoftwareDistribution\*.*
net start wuaserv >nul 2>&1
net start bits >nul 2>&1
echo this may take some time so plz wait
cleanmgr /sagerun:99
c:\windows\SYSTEM32\cleanmgr.exe /cDrive 
del /q/f/s C:\Windows\Prefetch\*.*
SETLOCAL EnableDelayedExpansion
for /F "tokens=1,2 delims=#" %%a in ('"prompt #$H#$E# & echo on & for %%b in (1) do     rem"') do (
  set "DEL=%%a"
)
call :colorEcho 0e "select all for best cleaning "
call :colorEcho 0a "for best cleaning"
:colorEcho
echo off
<nul set /p ".=%DEL%" > "%~2"
findstr /v /a:%1 /R "^$" "%~2" nul
echo _this may take some time so plz wait
del "%~2" > nul 2>&1i
%SystemRoot%\System32\Cmd.exe /c Cleanmgr /sageset:35 & Cleanmgr /sagerun:35
echo x=msgbox("thank you for using our tool Note:-make sure that app is running as administator otherwise it will not work" ,0+64, "thank you") >> %temp%/msgbox.vbs

start %temp%/msgbox.vbs
TIMEOUT /T 1 
cd %temp%
del /q/f/s msgbox.vbs 
TIMEOUT /T 10
exit:
:somewhere_else
exit:

