using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ZMario.Engine;

namespace ZMario.GameObjects
{
    public class PlayerController : AnimatedGameComponent
    {
        // Physics fields
        private float gr_acceleration = 15.0f;
        private float gr_friction = 10.0f;
        private float gr_maxSpeed = 2.5f;
        private float gr_maxRunSpeed = 5f;

        private Vector2 velocity = Vector2.Zero;

        // Input handler
        IInputHandler input;

        public PlayerController(Game game, IInputHandler input) 
            : base(game)
        {
            this.input = input;
            elapsedAnimTime = TimeSpan.Zero;
            LoadDefaultMarioAnimations();
        }

        public Vector2 Velocity
        {
            get
            {
                return velocity;
            }
            set
            {
                velocity = value;
            }
        }


        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            this.GroundMovement(deltaTime);
            this.Move();
            this.UpdateAnimation(gameTime);
        }

        public void GroundMovement(float deltaTime)
        {
            if (input.IsActionPressed("move_r") && !input.IsActionPressed("move_l"))
            {
                velocity.X += gr_acceleration * deltaTime;
            }
            else if (input.IsActionPressed("move_l") && !input.IsActionPressed("move_r"))
            {
                velocity.X -= gr_acceleration * deltaTime;
            }
            else
            {
                if (velocity.X < 0)
                {
                    if (velocity.X + gr_friction * deltaTime > 0) { velocity.X = 0; }
                    else { velocity.X += gr_friction * deltaTime; }
                }
                else if (velocity.X > 0)
                {
                    if (velocity.X - gr_friction * deltaTime < 0) { velocity.X = 0; }
                    else { velocity.X -= gr_friction * deltaTime; }
                }
            }

            if (velocity.X > gr_maxSpeed)
            {
                velocity.X = gr_maxSpeed;
            }
            else if (velocity.X < -gr_maxSpeed)
            {
                velocity.X = -gr_maxSpeed;
            }
        }

        private void Move()
        {
            this.Position += velocity;
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
            Animation walk = new Animation(walkf, TimeSpan.FromMilliseconds(100));

            // Run
            Animation run = new Animation(walkf, TimeSpan.FromMilliseconds(50));

            // Jump
            List<Rectangle> jumpf = new List<Rectangle>();
            jumpf.Add(new Rectangle(64, 16, 16, 16));
            Animation jump = new Animation(jumpf, TimeSpan.FromMilliseconds(1));

            // Add animations to anim list and set default animation to idle
            this.animations.Add("idle", idle);
            this.animations.Add("walk", walk);
            this.animations.Add("run", run);
            this.animations.Add("jump", jump);

            this.CurrentAnimation = this.animations["walk"];
        }

        

    }
}
