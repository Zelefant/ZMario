using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.Engine
{
    /// <summary>
    /// Extended GameComponent for components that require animations.
    /// </summary>
    internal class AnimatedGameComponent : GameComponent
    {
        protected TextureAtlas atlas;
        protected Dictionary<string, Animation> animations;

        public AnimatedGameComponent(Game game, TextureAtlas atlas) 
            : base(game)
        {
            this.atlas = atlas;
            this.animations = new Dictionary<string, Animation>();
        }

        public void AddAnimation(string animationName, Animation animation)
        {
            this.animations.Add(animationName, animation);
        }

        public void RemoveAnimation(string animationName)
        {
            this.animations.Remove(animationName);
        }
    }
}
