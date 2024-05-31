@echo off
setlocal

echo Running Edit Mode Tests...
echo Workspace: %WORKSPACE%
cd %WORKSPACE%\TicTacToe

:: Run Unity edit mode tests
"C:\Program Files\Unity\Hub\Editor\2022.3.31f1\Editor\Unity.exe" -batchmode -nographics -quit -projectPath %WORKSPACE%\TicTacToe -runTests -testPlatform editmode -logFile %WORKSPACE%\editmode_tests.log

endlocal
