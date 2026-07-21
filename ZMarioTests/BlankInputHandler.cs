using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;
using ZMario.Engine;

namespace ZMarioTests
{
    internal class BlankInputHandler : IInputHandler
    {
        public bool IsActionJustPressed(string actionName)
        {
            return false;
        }

        public bool IsActionJustReleased(string actionName)
        {
            throw new NotImplementedException();
        }

        public bool IsActionPressed(string actionName)
        {
            return false;
        }

        public void Update()
        {
            return;
        }
    }
}
