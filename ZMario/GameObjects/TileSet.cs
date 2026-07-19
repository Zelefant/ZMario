using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.GameObjects
{
    internal class TileSet
    {
        public Texture2D TileMap { get; }

        public TileSet(Texture2D _tileMap)
        {
            TileMap = _tileMap;
        }
    }
}
