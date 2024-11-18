using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;

namespace EasySpawn
{
    public class SpawnWorld : World
    {
        private Random random = new Random();
        public SpawnWorld() : base(700, 500) // size of world
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (random.Next(0, 100) < 50)
            {
                SpawnWorm();
            }

        }
        private void SpawnWorm()
        {
            int x = random.Next(0, Width);
            int y = random.Next(0, Height);

            Add(new Worm(), "worm", x, y);
        }
    }
}
