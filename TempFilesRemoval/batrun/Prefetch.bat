@echo off
del /q/f/s C:/Windows/Prefetch/*.*"
echo x=msgbox("thank you for using our tool Note:-make sure that app is running as administator otherwise it will not work" ,0+64, "thank you") >> %temp%/msgbox.vbs

start %temp%/msgbox.vbs
TIMEOUT /T 1 
cd %temp%
del /q/f/s msgbox.vbs
exit