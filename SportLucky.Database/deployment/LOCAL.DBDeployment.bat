::@echo off

SET DIR=%~d0%~p0%

SET server.connectionstring="server=localhost;user id=root;password=sportlucky;persistsecurityinfo=True;database=sportlucky;allowuservariables=True"
SET server.databasetype="roundhouse.databases.mysql.MySqlDatabase, roundhouse"
SET sql.files.directory="..\db\"
SET rh.path= "..\Tools\RoundhousE\console\"
SET restore.path=%..\DatabaseBackups\
SET restore.name=sportlucky.bak

:: Run RH in RestoreRun mode
%rh.path%\rh.exe /dt %server.databasetype% /c %server.connectionstring% -f ..\db -w --debug /restore /rfp=%restore.path%\%restore.name% /simple
pause
