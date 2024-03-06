@echo off

set UNITY_PATH="C:\Program Files\Unity\Hub\Editor\2022.3.1f1\Editor\Unity.exe"
set PROJECT_PATH="C:\Users\avaryvonchyk\GameDev\WebGL test"
set BUILD_TARGET=StandaloneWindows
set BUILD_PATH="C:\Users\avaryvonchyk\GameDev\WebGL test\Builds"
set LOG_PATH= "C:\Users\avaryvonchyk\GameDev\WebGL test\Logs\windowsBuildLog.txt"

%UNITY_PATH% -batchmode -projectPath %PROJECT_PATH% -buildTarget %BUILD_TARGET% -logFile %LOG_PATH% -executeMethod Builder.BuildWindowsStandalone -quit
