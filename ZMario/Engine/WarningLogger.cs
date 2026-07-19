using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.Engine
{
    internal class WarningLogger : ILogger
    {
        public string Name => "WARN";

        public ConsoleColor color => ConsoleColor.Yellow;

        public void Log(string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("[" + this.Name + "] " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
