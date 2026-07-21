using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.Engine
{
    public class MarioGameComponent : GameComponent
    {
        Vector2 position = Vector2.Zero;

        public MarioGameComponent(Game game) 
            : base(game)
        {
        }

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
