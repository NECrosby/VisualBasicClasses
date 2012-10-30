s:
cd \XPInstall\sysprepimage
mkdir c:\Sysprep
xcopy /q/Y S:\XPInstall\sysprepimage\sysprep\*.* c:\Sysprep
S:\XPInstall\sysprepimage\sysprep\sysprep -MINI -QUIET -RESEAL -SHUTDOWN
pause