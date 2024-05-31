@echo off
setlocal

REM Path to your Unity executable
set UNITY_PATH="C:\Program Files\Unity\Hub\Editor\2022.3.31f1\Editor\Unity.exe"

REM Path to your Unity project
set PROJECT_PATH="TicTacToe"

REM Name of the method to execute
set METHOD_NAME="BuildScript.BuildProject"

REM Execute the build
%UNITY_PATH% -quit -batchmode -projectPath %PROJECT_PATH% -executeMethod %METHOD_NAME%

endlocal
