using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
    public class AnimatedGameComponent : MarioGameComponent
    {
        protected Texture2D atlas;
        protected Dictionary<string, Animation> animations;

        protected Animation _animation;
        protected int _currentFrame = 0;
        protected TimeSpan elapsedAnimTime;
        protected Rectangle spriteRect;

        public AnimatedGameComponent(Game game, Texture2D atlas)
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

        public void UpdateAnimation(GameTime gameTime)
        {
            elapsedAnimTime += gameTime.ElapsedGameTime;

            if (elapsedAnimTime >= _animation.Delay)
            {
                elapsedAnimTime -= _animation.Delay;
                _currentFrame++;

                if (_currentFrame >= _animation.Frames.Count)
                {
                    _currentFrame = 0;
                }

                spriteRect = _animation.Frames[_currentFrame];
            }
        }

        public Texture2D Atlas => this.atlas;

        public Animation CurrentAnimation
        {
            get => _animation;
            set
            {
                _animation = value;
                _currentFrame = 0;
                spriteRect = _animation.Frames[_currentFrame];
            }
        }

        public Rectangle Region { get { return spriteRect; } }

    }
}
