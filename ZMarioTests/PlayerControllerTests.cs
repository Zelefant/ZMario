using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using ZMario.Engine;
using ZMario.GameObjects;

namespace ZMarioTests
{
    [TestClass]
    public class PlayerControllerTests
    {

        [TestMethod]
        public void Update_MovesPlayer()
        {
            GameTime time = new GameTime(
                TimeSpan.Zero,
                TimeSpan.FromSeconds(0.1));

            Game game = new Game();
            BlankInputHandler input = new BlankInputHandler();

            PlayerController controller = new PlayerController(game, input);

            controller.Velocity = new Vector2(2f, 0f);

            controller.Update(time);

            Assert.AreEqual(new Vector2(1f, 0f), controller.Velocity);
            Assert.AreEqual(new Vector2(1f, 0f), controller.Position);
        }
    }
}
