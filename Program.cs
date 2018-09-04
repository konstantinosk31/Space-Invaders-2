using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Space_Invaders_2
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            Player p = new Player();
            File.WriteAllText("data.dat", "10");
            world.ghostMap = new Ghost[world.ghCntY + 1, world.ghCntX + 1];
            int ghStartX = (world.wallX1 + world.wallX2) / 2 - world.ghCntX - 1;
            for(int y = 1; y <= world.ghCntY; y++)
            {
                for(int x = 1; x <= world.ghCntX; x++)
                {
                    world.ghostMap[y, x] = new Ghost(2*y, ghStartX + 2 * x);
                }
            }
            Thread t = new Thread(input);
            t.Start();
            while (!world.GameOver)
            {
                world.ShowWall();
                for (int y = 1; y <= world.ghCntY; y++)
                {
                    for (int x = 1; x <= world.ghCntX; x++)
                    {
                        world.ghostMap[y, x].Show();
                        if (File.Exists("data.dat"))
                        {
                            try
                            {
                                p.setx(int.Parse(File.ReadAllText("data.dat")));
                                File.Delete("data.dat");
                            }
                            catch (IOException e)
                            {

                            }
                        }
                        p.Show();
                    }
                }
                Thread.Sleep(200);
                world.MoveGhosts();
                Console.Clear();
            }
        }
        static void input()
        {
            Player p = new Player();
            int cord = 10;
            while (true)
            {
                Console.SetCursorPosition(27, 27);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    p.move(-1);
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    p.move(1);
                }
                cord = p.getx();
                try
                {
                    File.WriteAllText("data.dat", cord.ToString());
                }
                catch (IOException e)
                {

                }
                Thread.Sleep(30);
            }
        }
    }
}
