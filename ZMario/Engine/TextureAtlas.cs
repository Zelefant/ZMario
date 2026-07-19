using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.Engine
{
    internal class TextureAtlas
    {
        public Texture2D atlas { get; }

        public TextureAtlas(Texture2D atlas)
        {
            this.atlas = atlas;
        }
    }
}
