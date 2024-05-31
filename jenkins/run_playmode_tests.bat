@echo off
setlocal

echo Running Play Mode Tests...
echo Workspace: %WORKSPACE%
cd %WORKSPACE%\TicTacToe

:: Run Unity play mode tests
"C:\Program Files\Unity\Hub\Editor\2022.3.31f1\Editor\Unity.exe" -batchmode -nographics -quit -projectPath %WORKSPACE%\TicTacToe -runTests -testPlatform playmode -logFile %WORKSPACE%\playmode_tests.log

endlocal
