using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.Engine
{
    public class InputHandler : IInputHandler
    {
        KeyboardState oldState = new KeyboardState(); // Last frame
        KeyboardState newState = new KeyboardState(); // Current frame

        Dictionary<string, Keys> actions = new Dictionary<string, Keys>();

        public InputHandler()
        {

        }

        public Dictionary<string, Keys> KeyboardActions
        {
            get
            {
                return actions;
            }
        }

        /// <summary>
        /// This method loads an action keybind into the keybind dictionary.
        /// </summary>
        /// <param name="actionName">Name of the action.</param>
        /// <param name="key">Key to bind to the action.</param>
        public void RegisterKeybind(string actionName, Keys key)
        {
            this.actions[actionName] = key;
        }

        public void Update()
        {
            oldState = newState;
            newState = Keyboard.GetState();
        }

        public bool IsActionPressed(string actionName)
        {
            if (this.actions.ContainsKey(actionName))
            {
                if (this.newState.IsKeyDown(this.actions[actionName]))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsActionJustPressed(string actionName)
        {
            if (this.actions.ContainsKey(actionName))
            {
                if (this.newState.IsKeyDown(this.actions[actionName]) && this.oldState.IsKeyUp(this.actions[actionName]))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsActionJustReleased(string actionName)
        {
            throw new NotImplementedException();
        }
    }
}
