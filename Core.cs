using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAD_SCRIPT;
using System.Threading;


class Core
{
	public void printConsole(string a)
	{
		Console.WriteLine(a);
	}

    public bool FileExists(string a)
    {
        try
        {
            if (System.IO.File.Exists(a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception i)
        {
            Console.WriteLine(i.Message);
        }
        return false;
    }

    public void WriteFile(string filename, string info)
    {
        try
        {
            System.IO.File.WriteAllText(filename, info);
        }
        catch (Exception i)
        {
        }
    }

    public void deleteFile(string a)
    {
        try
        {
            System.IO.File.Delete(a);
        }
        catch (Exception i)
        {
            Console.WriteLine(i.Message);
        }
    }

	public PADScript loadScript(PADScript l)
	{
		l.addLuaCommand("printConsole",this);
        l.addLuaCommand("FileExists", this);
        l.addLuaCommand("WriteFile", this);
        l.addLuaCommand("deleteFile", this);
		return l;		
	}
}
        