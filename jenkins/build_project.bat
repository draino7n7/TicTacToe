@echo off
setlocal

echo Building Unity project...
echo Workspace: %WORKSPACE%
cd %WORKSPACE%\TicTacToe

:: Run Unity build command
"C:\Program Files\Unity\Hub\Editor\2022.3.31f1\Editor\Unity.exe" -batchmode -nographics -quit -projectPath %WORKSPACE%\TicTacToe -executeMethod BuildScript.BuildProject -logFile %WORKSPACE%\build.log

endlocal
