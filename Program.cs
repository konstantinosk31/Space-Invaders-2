using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Space_Invaders_2
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            world.ghostMap = new Ghost[world.ghCntY + 1, world.ghCntX + 1];
            int ghStartX = (world.wallX1 + world.wallX2) / 2 - world.ghCntX - 1;
            for(int y = 1; y <= world.ghCntY; y++)
            {
                for(int x = 1; x <= world.ghCntX; x++)
                {
                    world.ghostMap[y, x] = new Ghost(2*y, ghStartX + 2 * x);
                }
            }
            while (!world.GameOver)
            {
                world.ShowWall();
                for (int y = 1; y <= world.ghCntY; y++)
                {
                    for (int x = 1; x <= world.ghCntX; x++)
                    {
                        world.ghostMap[y, x].Show();
                    }
                }
                Thread.Sleep(100);
                world.MoveGhosts();
                Console.Clear();
            }
        }
    }
}