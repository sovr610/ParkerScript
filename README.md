ParkerScript
============

ParkerScript, built off of PADScript and Lua. Dynamic and fun to use!

Hello and welcome! I am glad you choose ParkerScript. Also yes my real name is Parker Bidigare.
Ok done to the fun stuff! here is the install:
---------------------------------------------INSTALL-------------------------------------------
1. make sure you have .NET 4.5, 4.5.1 and (optinal) 4.5.2
2. if you are running windows 7 skip the install and read the bottom of this readme for further instructions.
3. make sure you understand some lua since PADScript runs on lua and ParkerScript runs on PADScript.
4. 

-----------------------------------------------------------------------------------------------

How to add commands to ParkerScript with C#:
1. Write a generic class in C# with methods to be added in ParkerScript
2. add a using with PAD_SCRIPT as a reference
3. add a method: 
      public PADScript LoadScript(PADScript l)
      {
          l.addLuaCommand("Other_Method_Name",this);
      }
4. For every method you have in the class you add another l.addLuaCommand() with the 
   Method_Name as the custom method name that you made. 
5. The next thing you do is open the FunctionList.txt and add two lines for your custom class.
   Here is an example of adding a custom C# class called Core:
      a: Core core = new Core();
      b: p = core.LoadScript(p);
  
    *Ok so the a: tells the interpreter that is the initializing part of your class
    *the b: is the LoadScript method being called to load your custom methods into ParkerScript
     p is the reference variable of PADScript that you need have equal to the method and send
     an argument of p.
6.not just execute the API_ADDER and let that run, exit out of the csc.exe (C# compiler) program and you can now 
  startup the ParkerScript.exe to see that your commands are added into the scripting language.

7. If you have an issue compiling the C# code it is most likely from not having the same .NET version
   and all you have to do is set the directory of the csc.exe file to the right folder.

-------------------------------------------------------------------------------------------------


IF YOU HAVE WINDOWS 7:
1. You are needing to edit the compile.bat where the directory is set to where your csc.exe file is

--------------------------------------------------------------------------------------------------
By: Parker Bidigare, e-mail: work.simpleintelligence@gmail.com, 2014
