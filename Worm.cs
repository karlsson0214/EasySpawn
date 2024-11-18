using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;

namespace EasySpawn
{
    internal class Worm : Actor
    {
        public Worm()
        {

        }

        public override void Update(GameTime gameTime)
        {
            if (IsTouching(typeof(Worm)))
            {
                RemoveTouching(typeof(Worm));
            }
        }
    }
}
