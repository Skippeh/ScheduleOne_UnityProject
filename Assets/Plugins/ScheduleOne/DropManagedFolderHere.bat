@ECHO OFF
SETLOCAL EnableDelayedExpansion

TITLE DLL Meta Matcher

REM Get the directory where this script is located
SET "ScriptDir=%~dp0"

REM Check if an item was dropped
IF "%~1"=="" (
    REM No folder was dropped onto the script.
    GOTO End
)

REM Check if the dropped item is a directory
IF NOT EXIST "%~1\\" (
    ECHO Error: The dropped item is not a valid folder: "%~1" >&2
    GOTO End
)

SET "DroppedFolder=%~1"
ECHO Processing folder: "%DroppedFolder%"

REM Iterate through all DLL files within the dropped folder
FOR %%F IN ("!DroppedFolder!\\*.dll") DO (
    SET "BaseName=%%~nF"
    SET "MetaFilePath=!ScriptDir!!BaseName!.dll.meta"
    SET "TargetDLLPath=!ScriptDir!!BaseName!.dll"

    IF EXIST "!MetaFilePath!" (
        IF NOT EXIST "!TargetDLLPath!" (
            COPY "%%~fF" "!ScriptDir!" > NUL
            IF NOT !ERRORLEVEL! EQU 0 (
                ECHO Error: COPY FAILED for "%%~nxF"! Error Code: !ERRORLEVEL! >&2
            )
        )
    )
)

ECHO Processing complete.
PAUSE

:End
EXIT 