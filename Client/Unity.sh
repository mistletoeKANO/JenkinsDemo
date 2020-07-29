#!/bin/sh
echo "start"

export unity=/Applications/Unity/Unity.app

export projectPath=/Users/lta/UnityProjects/JenkinsDemo/Client

for a in $*
do
    r='echo $a | sed "s/--//g"'
    eval $r
done

echo "version = $version"

$unity -quit -batchmode -projectPath $projectPath -logFile /tmp/1.log -executeMethod APKBuild.build "$version"

echo apk生成完毕！

