using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.Engine
{
    internal class ErrorLogger : ILogger
    {
        public string Name => "ERROR";

        public ConsoleColor color => ConsoleColor.Red;

        public void Log(string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("[" + this.Name + "] " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
