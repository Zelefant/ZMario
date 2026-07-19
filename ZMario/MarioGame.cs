using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ZMario.Engine;

namespace ZMario
{
    public class MarioGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D tileset;

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
            gameLogger.Log("Systems booting up...");
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            gameLogger.Log("Loading textures");
            tileset = Texture2D.FromFile(GraphicsDevice, "MarioResources/tileset.png");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.MonoGameOrange);

            // TODO: Add your drawing code here

            // Draw the sprite batch.
            _spriteBatch.Begin();
            _spriteBatch.Draw(
                tileset,
                Vector2.Zero,
                new Rectangle(0, 0, 16, 16),
                Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
