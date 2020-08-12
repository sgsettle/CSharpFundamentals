using _08_StreamingContent_ConsoleUI.Consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a RealConsole for the "production" app
            var console = new RealConsole();

            // UI Class Instance
            // creating new ProgramUI class
            ProgramUI ui = new ProgramUI(console);
            // calling Start method (instance) from ProgramUI class
            // directs us to what code we want to run next
            ui.Start();
        }
    }
}
