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
            // UI Class Instance
            // creating new ProgramUI class
            ProgramUI ui = new ProgramUI();
            // calling Start method (instance) from ProgramUI class
            // directs us to what code we want to run next
            ui.Start();
        }
    }
}
