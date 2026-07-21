namespace ZMarioTests;

using ZMario.Engine;

[TestClass]
public class InputHandlerTests
{
    [TestMethod]
    public void TestRegisterKeybind_Default()
    {
        InputHandler input = new InputHandler();
        input.RegisterKeybind("test_action", Microsoft.Xna.Framework.Input.Keys.Space);

        Assert.AreEqual(
            Microsoft.Xna.Framework.Input.Keys.Space, 
            input.KeyboardActions["test_action"],
            "Values should match after registration.");
    }

    [TestMethod]
    public void TestRegisterKeybind_OverwriteExisting()
    {
        InputHandler input = new InputHandler();
        
        input.RegisterKeybind("test_action", Microsoft.Xna.Framework.Input.Keys.Space);
        input.RegisterKeybind("test_action", Microsoft.Xna.Framework.Input.Keys.LeftShift);

        Assert.AreNotEqual(
            Microsoft.Xna.Framework.Input.Keys.Space,
            input.KeyboardActions["test_action"],
            "Values should no longer match after registration overwrite.");

        Assert.AreEqual(
            Microsoft.Xna.Framework.Input.Keys.LeftShift,
            input.KeyboardActions["test_action"],
            "Values should match after registration overwrite.");

    }
}
