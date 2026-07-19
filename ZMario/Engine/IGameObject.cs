using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.Engine
{
    internal interface IGameObject
    {
        // Initialization method for when the object is created or, if exists at scene start, when the scene is fully loaded.
        void Initialize();

        // Update method that is called every frame.
        // Delta Time should be passed every time, it is up to the game object if it uses it.
        // Delta Time is used to untie object updations from the frame rate.
        void Update(float deltaTime);

    }
}
