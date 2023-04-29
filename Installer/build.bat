"C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" ..\QuickDBAccess.csproj /property:Configuration=Release
"C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" ..\QuickDBAccess.csproj /property:Configuration=Release(x64)

"C:\Program Files (x86)\Inno Setup 6\ISCC.exe" installer.iss

mkdir _Temp_
mkdir _Temp_\QDBA_32bit
mkdir _Temp_\QDBA_64bit

xcopy ..\bin\Release _Temp_\QDBA_32bit /E
xcopy ..\bin\Release(x64) _Temp_\QDBA_64bit /E

del _Temp_\QDBA_32bit\config.xml
del _Temp_\QDBA_32bit\QDBA.application
del _Temp_\QDBA_32bit\QDBA.exe.config
del _Temp_\QDBA_32bit\QDBA.exe.manifest
del _Temp_\QDBA_32bit\QDBA.pdb
del _Temp_\QDBA_32bit\QDBA.chm

rmdir _Temp_\QDBA_32bit\app.publish /S /Q

del _Temp_\QDBA_64bit\config.xml
del _Temp_\QDBA_64bit\QDBA.application
del _Temp_\QDBA_64bit\QDBA.exe.config
del _Temp_\QDBA_64bit\QDBA.exe.manifest
del _Temp_\QDBA_64bit\QDBA.pdb
del _Temp_\QDBA_64bit\QDBA.chm

rmdir _Temp_\QDBA_64bit\app.publish /S /Q

cd _Temp_\QDBA_32bit\
"C:\Program Files\7-Zip\7z.exe" a ..\..\bin\QDBA_32bit.zip "*"
cd ..\..

cd _Temp_\QDBA_64bit\
"C:\Program Files\7-Zip\7z.exe" a ..\..\bin\QDBA_64bit.zip "*"
cd ..\..

rmdir _Temp_ /S /Q