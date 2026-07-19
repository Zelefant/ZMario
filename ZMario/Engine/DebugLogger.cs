using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.Engine
{
    internal class DebugLogger : ILogger
    {
        public string Name => "DEBUG";

        public ConsoleColor color => ConsoleColor.White;

        public bool Debug
        {
            get; set;
        }

        public void Log(string message)
        {
            if (Debug)
            {
                Console.ForegroundColor = color;
                Console.WriteLine("[" + this.Name + "] " + message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
