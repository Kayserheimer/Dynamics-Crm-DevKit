@echo off
set /p VERSION=<version.txt
echo ************************************************************
echo Building solution: DEPLOY RELEASE MODE - version: %VERSION%
echo ************************************************************
if exist "DynamicsCrm.DevKit.Console\bin\Debug\DynamicsCrm.DevKit.Console.exe" (
    echo running DynamicsCrm.DevKit.Console.exe
    call DynamicsCrm.DevKit.Console\bin\Debug\DynamicsCrm.DevKit.Console.exe
    echo ************************************************************
)
set MsBuild=""
if exist "C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\MSBuild.exe" (
	set MsBuild="C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\MSBuild.exe"
)
if %MsBuild%=="" (
	echo msbuild.exe not found !!!
) else (
    echo Building solutions ...
	if exist Published\%VERSION%\ (
		del Published\%VERSION%\*.* /f /q
	)
	if not exist Published\%VERSION% ( md Published\%VERSION% )
	call %MsBuild% /nologo /noautorsp /verbosity:minimal -p:Configuration=Release -target:Clean;Build DynamicsCrm.DevKit.sln    

    echo ************************************************************
    echo NuGet pack ...
    echo ************************************************************

	rem cd DynamicsCrm.DevKit.Analyzers\Nuget
	rem call pack.bat

	rem cd ..\..
	rem cd DynamicsCrm.DevKit.Cli\Nuget
	rem call pack.bat

	rem cd ..\..
	rem cd DynamicsCrm.DevKit.Tool\Nuget
	rem call pack.bat

	rem cd ..\..
	copy DynamicsCrm.DevKit\bin\Release\DynamicsCrm.DevKit.vsix Published\%VERSION%\DynamicsCrm.DevKit.%VERSION%.vsix

    rem call DynamicsCrm.DevKit.Console\bin\Debug\DynamicsCrm.DevKit.Console.exe 1
)