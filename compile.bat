@echo off
C:\WINDOWS\Microsoft.Net\Framework\v4.0.30319\csc.exe /platform:x86 /reference:library\LuaInterface.dll /reference:library\PAD_SCRIPT.dll /reference:library\lua51.dll /optimize /out:ParkerScript.exe /define:DEBUG /recurse:AsmInfo /doc:ParkerScript.xml  *.cs
pause