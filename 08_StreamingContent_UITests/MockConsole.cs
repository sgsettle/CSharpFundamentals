using _08_StreamingContent_ConsoleUI.Consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_UITests
{
    class MockConsole : IConsole
    {
        // This will be the list of steps the "user" would take
        public Queue<string> UserInput;
        // queue has built in order

        // Whatever is output from the ProgramUI
        public string Output = "";

        // Constructor
        public MockConsole(IEnumerable<string> input)
            // IEnumerable - exposes the enumerator
        {
            // Declares a new Queue that is populated with the given IEnumerable
            UserInput = new Queue<string>(input);
        }

        public void Clear()
        {
            Output += "Called Clear Method\n";
        }

        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }

        public string ReadLine()
        {
            return UserInput.Dequeue();
        }

        public void Write(string s)
        {
            Output += s;
        }

        public void WriteLine(string s)
        {
            Output += s + "\n";
        }

        public void WriteLine(object o)
        {
            Output += o + "\n";
        }
    }
}
