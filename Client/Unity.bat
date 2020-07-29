@echo off

echo 正在生成apk文件。。。

REM /Applications/Unity/Unity.app -projectPath /Users/lta/UnityProjects/JenkinsDemo/Client -quit -batchmode -executeMethod APKBuild.build -logFile build.log

%1 -projectPath %2 -quit -batchmode -executeMethod APKBuild.build -logFile build.log

echo apk生成完毕！

pause