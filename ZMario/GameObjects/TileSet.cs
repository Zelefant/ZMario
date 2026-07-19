using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.GameObjects
{
    /// <summary>
    /// Tilesets are atlases used by the Tile class.
    /// </summary>
    internal class TileSet
    {
        public Texture2D TileMap { get; }

        public TileSet(Texture2D _tileMap)
        {
            TileMap = _tileMap;
        }
    }
}
