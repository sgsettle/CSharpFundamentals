using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_ConsoleUI.Consoles
{
    public interface IConsole
    {
        void WriteLine(string s);
        // calling it "s" just as an abbreviation for string
        // don't typically use one letter variable
        void WriteLine(object o);
        // we don't know what we're passing yet, so allows us to pass anything that isn't a string
        void Write(string s);
        void Clear();
        string ReadLine();
        ConsoleKeyInfo ReadKey();
    }
}
