@echo off
echo Plz make sure that app has admin access otherwise it will have infinite error loops if this massage appears again then you dont have admin access
timeout /T 5
%SystemRoot%\System32\Cmd.exe /c Cleanmgr /sageset:35 & Cleanmgr /sagerun:35 
echo x=msgbox("thank you for using our tool Note:-make sure that app is running as administator otherwise it will not work" ,0+64, "thank you") >> %temp%/msgbox.vbs

start %temp%/msgbox.vbs
TIMEOUT /T 1 
cd %temp%
del /q/f/s msgbox.vbs
exit