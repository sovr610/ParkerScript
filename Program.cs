using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAD_SCRIPT;
using System.Threading;

namespace ParkerScript2
{
    class Program
    {
        //LOAD_REF

	 Core core = new Core();


        //END_REF

	PADScript p = new PADScript();
        static void Main(string[] args)
        {
            Program p = new Program();
	    p.loadCustomScripts();
            if (args.Length == 0)
            {
                p.console();
            }
            else
            {
		Console.WriteLine("ParkerScript> running File!");
                foreach (string a in args)
                {
                    if (a != null)
                    {
			string ii = a.Replace("/","");
                        p.runFile(ii);
                    }
                }
            }
        }

        public void loadScripts()
        {

        }

        public void runFile(string file)
        {
            if (file.ToLower().Contains(".pb"))
            {
                //file = file.Replace(".pb", "");
                p.executeLuaWithThread(file);
		Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ERROR 1: must be .pb file");
                Console.ReadLine();
            }
        }

        public void console()
        {
            Console.WriteLine("-----------------COMMAND LINE MODE------------------------");
            Console.WriteLine("|   *Enter In /exit() to end command line                 |");
            Console.WriteLine("|   *Developed by Parker Bidigare:                        |");
            Console.WriteLine("|    *work.simpleintelligence@gmail.com                   |");
            Console.WriteLine("|    *Powered by Lua, http://www.Lua.org                  |");
            Console.WriteLine("-----------------------------------------------------------");
            while (true)
            {
		Console.Write("ParkerScript> ");
                string cmd = Console.ReadLine();
                if (cmd == "/exit()")
                    break;
                if (cmd != null)
                {
                    p.executeLuaLine(cmd);
                }
            }
        }

        //this will be dynamically be updated when custom cs code gets added
        public void loadCustomScripts()
        {

	 p = core.loadScript(p);

        }

    }
}

       
