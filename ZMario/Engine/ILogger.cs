using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.Engine
{
    internal interface ILogger
    {
        void Log(string message);

        string Name { get; }
    }
}
