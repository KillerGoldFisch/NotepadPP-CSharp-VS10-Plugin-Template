ECHO OFF

SET TemplateName="NppPlugin2.0"

FOR /F "tokens=2* delims=	 " %%A IN ('REG QUERY "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders" /v Personal') DO SET Documents=%%B
ECHO Documents=%Documents%



rem ------------------------------- VS10 -------------------------------------------------


SET VS10Templates=%Documents%\Visual Studio 2010\Templates\ProjectTemplates\Visual C#


ECHO Test for %VS10Templates%
IF NOT EXIST %VS10Templates% GOTO NOVS10
	ECHO Found VS10 Template Directory.
	ECHO Zip Folder
	"%ProgramFiles%\7-Zip\7z.exe" a -tzip -mx7 -r "%~dp0\%TemplateName%.zip" "%~dp0\*"
	ECHO Copy new Template to %VS10Templates%
	move "%~dp0\%TemplateName%.zip" "%VS10Templates%\%TemplateName%.zip"
:NOVS10

ECHO DONE
pause