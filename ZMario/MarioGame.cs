using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ZMario.Engine;
using ZMario.GameObjects;

namespace ZMario
{
    public class MarioGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D tileset;
        private InputHandler input = new InputHandler();

        private List<GameComponent> componentsList = new List<GameComponent>();

        private GameLogger gameLogger = new GameLogger();
        private WarningLogger warnLogger = new WarningLogger();

        public MarioGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferHeight = 600;
            _graphics.PreferredBackBufferWidth = 600;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            gameLogger.Log("Setting up game...");
            warnLogger.Log("This is a prototype!");

            // Basic keybind loader
            gameLogger.Log("Loading keybinds");
            input.RegisterKeybind("move_r", Keys.Right);
            input.RegisterKeybind("move_l", Keys.Left);
            input.RegisterKeybind("jump", Keys.Space);
            input.RegisterKeybind("run", Keys.LeftShift);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            gameLogger.Log("Loading textures");
            tileset = Texture2D.FromFile(GraphicsDevice, "MarioResources/tileset.png");

            Texture2D spritesheet = Texture2D.FromFile(GraphicsDevice, "MarioResources/spritesheet.png");
            PlayerController mario = new PlayerController(this, input);
            componentsList.Add(mario);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Get Input
            input.Update();

            // TODO: Add your update logic here

            foreach (GameComponent comp in componentsList)
            {
                comp.Update(gameTime);
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.MonoGameOrange);

            // TODO: Add your drawing code here

            // Draw the sprite batch.
            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            foreach (GameComponent comp in componentsList)
            {
                if (comp is AnimatedGameComponent animComp)
                {
                    _spriteBatch.Draw(
                        animComp.Atlas,
                        animComp.Position,
                        animComp.Region,
                        Color.White,
                        0f,
                        Vector2.Zero,
                        2f,
                        SpriteEffects.None,
                        0f);
                }
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
