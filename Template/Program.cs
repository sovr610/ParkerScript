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


        //END_REF

	PADScript p = new PADScript();
        static void Main(string[] args)
        {
            Program p = new Program();
	    p.loadCustomScripts();
            if (!args.Contains("/"))
            {
                p.console();
            }
            else
            {
                foreach (string a in args)
                {
                    if (a != null)
                    {
                        p.runFile(a);
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
                file = file.Replace(".pb", ".lua");
                p.executeLuaWithThread(file);
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
            Console.WriteLine("|   *Enter In /exit to end command line                   |");
            Console.WriteLine("|   *Developed by Parker Bidigare:                        |");
            Console.WriteLine("|    *work.simpleintelligence@gmail.com                   |");
            Console.WriteLine("|    *Powered by Lua, http://www.Lua.org                  |");
            Console.WriteLine("-----------------------------------------------------------");
            while (true)
            {
		Console.Write("PADScript> ");
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

        }

    }
}

       