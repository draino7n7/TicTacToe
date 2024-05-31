@echo off
setlocal

REM Path to your Unity executable
set UNITY_PATH="C:\Program Files\Unity\Hub\Editor\2022.3.31f1\Editor\Unity.exe"

REM Path to your Unity project
set PROJECT_PATH="TicTacToe"

REM Path to save the test results
set RESULTS_PATH="C:\TestResults"

REM Execute the Edit mode tests
%UNITY_PATH% -batchmode -projectPath %PROJECT_PATH% -runTests -testPlatform EditMode -logFile %RESULTS_PATH%\EditModeTestResults.log -testResults %RESULTS_PATH%\EditModeTestResults.xml

endlocal
