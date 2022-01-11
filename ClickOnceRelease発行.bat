call "C:\Program Files\Microsoft Visual Studio\2022\Professional\Common7\Tools\VsDevCmd.bat"
cd %~dp0
msbuild ClickOnceBuildConfiguration.sln /t:Publish /t:CopyPublishedApplication /p:Configuration=Release /p:PublishUrl="publish\Release\\" /p:InstallUrl="\\Win10Test\publish_Release\\"
