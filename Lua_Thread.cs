using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lua511;
using LuaInterface;


    public class Lua_Thread
    {
        private Lua l;
        private string file;

        public Lua_Thread(string file, Lua l)
        {
            this.l = l;
            this.file = file;
        }

        public void run()
        {
            try
            {
                l.DoFile(file);
            }
            catch (Exception i)
            {
                Console.WriteLine(i.Message);
            }
        }
    }

