using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMario.Engine
{
    public class Animation
    {

        public Animation()
        {
            Frames = new List<Rectangle>();
            Delay = TimeSpan.FromMilliseconds(100);
        }

        public Animation(List<Rectangle> frames, TimeSpan delay)
        {
            Frames = frames;
            Delay = delay;
        }

        /// <summary>
        /// The texture regions that make up the frames of this animation.  The order of the regions within the collection
        /// are the order that the frames should be displayed in.
        /// </summary>
        public List<Rectangle> Frames { get; set; }

        /// <summary>
        /// The amount of time to delay between each frame before moving to the next frame for this animation.
        /// </summary>
        public TimeSpan Delay { get; set; }
    }
}
