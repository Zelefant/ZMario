using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.GameObjects
{
    /// <summary>
    /// Tiles are non-animated static objects on a grid in the world.
    /// </summary>
    internal class Tile : GameComponent
    {
        public Tile(Game game, TileSet tileSet, Rectangle tileRect, int tileID) 
            : base(game)
        {
            _TileSet = tileSet;
            _TileRect = tileRect;
            _TileID = tileID;
        }

        public int _TileID { get; }
        public TileSet _TileSet { get; }
        public Rectangle _TileRect { get; }
    }
}
