using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.GameObjects
{
    internal class Tile : GameComponent
    {
        public Tile(Game game, TileSet tileSet, Rectangle tileRect) 
            : base(game)
        {
            _TileSet = tileSet;
            _TileRect = tileRect;
        }

        public TileSet _TileSet { get; }
        public Rectangle _TileRect { get; }
    }
}
