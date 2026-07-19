using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.Engine
{
    internal class GameLogger : ILogger
    {
        public string Name => "GAME";

        public ConsoleColor color => ConsoleColor.White;

        public void Log(string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
