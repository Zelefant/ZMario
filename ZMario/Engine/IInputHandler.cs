using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.Engine
{
    public interface IInputHandler
    {

        public void Update();

        public bool IsActionPressed(string actionName);

        public bool IsActionJustPressed(string actionName);

        public bool IsActionJustReleased(string actionName);

    }
}
