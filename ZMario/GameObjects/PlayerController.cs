using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ZMario.Engine;

namespace ZMario.GameObjects
{
    internal class PlayerController : AnimatedGameComponent
    {
        private float gr_acceleration = 1.0f;
        private float gr_friction = 1.0f;
        private float gr_maxSpeed = 10f;
        private float gr_maxRunSpeed = 15f;

        private Animation _animation;
        private Rectangle _currentFrame;

        public PlayerController(Game game, TextureAtlas atlas) 
            : base(game, atlas)
        {

        }

        public override void Update(GameTime gameTime)
        {
            
        }

        /// <summary>
        /// Loads the default Mario animations
        /// </summary>
        public void LoadDefaultMarioAnimations()
        {
            // Idle
            List<Rectangle> idlef = new List<Rectangle>();
            idlef.Add(new Rectangle(0, 16, 16, 16));
            Animation idle = new Animation(idlef, TimeSpan.FromMilliseconds(1));

            // Walk
            List<Rectangle> walkf = new List<Rectangle>();
            walkf.Add(new Rectangle(16, 16, 16, 16));
            walkf.Add(new Rectangle(32, 16, 16, 16));
            walkf.Add(new Rectangle(48, 16, 16, 16));
            Animation walk = new Animation(walkf, TimeSpan.FromMilliseconds(20));

            // Run
            Animation run = new Animation(walkf, TimeSpan.FromMilliseconds(10));

            // Jump
            List<Rectangle> jumpf = new List<Rectangle>();
            jumpf.Add(new Rectangle(64, 16, 16, 16));
            Animation jump = new Animation(jumpf, TimeSpan.FromMilliseconds(1));

            // Add animations to anim list and set default animation to idle
            this.animations.Add("idle", idle);
            this.animations.Add("walk", walk);
            this.animations.Add("run", run);
            this.animations.Add("jump", jump);
        }

        public Animation CurrentAnimation
        {
            get => _animation;
            set
            {
                _animation = value;
                _currentFrame = _animation.Frames[0];
            }
        }

    }
}
