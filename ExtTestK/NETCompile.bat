@echo off

"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\MSBuild.exe" "C:\Transfer\OutSystems\Components\ExtTestK\Source\NET\ExtTestK.sln" /nologo /verbosity:minimal /target:Rebuild /property:Configuration=Release