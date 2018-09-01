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
            Ghost g1 = new Ghost();
            Ghost g2 = new Ghost();
            Ghost g3 = new Ghost();
            Ghost g4 = new Ghost();
            Ghost g5 = new Ghost();
            Ghost g6 = new Ghost();
            Ghost g7 = new Ghost();
            Ghost g8 = new Ghost();
            Ghost g9 = new Ghost();
            Ghost g10 = new Ghost();


            g1.initialize(1, 1);
            g2.initialize(1, 2);
            g3.initialize(1, 3);
            g4.initialize(1, 4);
            g5.initialize(1, 5);
            g6.initialize(2, 1);
            g7.initialize(2, 2);
            g8.initialize(2, 3);
            g9.initialize(2, 4);
            g10.initialize(2, 5);

            while (true)
            {
                do
                {
                    while ((Console.ReadKey(true).Key != ConsoleKey.LeftArrow) || (Console.ReadKey(true).Key != ConsoleKey.RightArrow))
                    {
                        g1.Show();
                        g2.Show();
                        g3.Show();
                        g4.Show();
                        g5.Show();
                        g6.Show();
                        g7.Show();
                        g8.Show();
                        g9.Show();
                        g10.Show();
                        Thread.Sleep(100);
                    }
                } while ((Console.ReadKey(true).Key != ConsoleKey.LeftArrow) || (Console.ReadKey(true).Key != ConsoleKey.RightArrow));
            }
            
        }
    }
    class Ghost
    {
        private bool state = true;
        private int x = 0, y = 0;
        public void initialize (int x1, int y1)
        {
            Ghost gh = new Ghost();
            gh.x = x1;
            gh.y = y1;
        }
        public void Show()
        {
            if (state == true)
            {
                Ghost gh = new Ghost();
                int x, y;
                x = gh.x * 2;
                y = gh.y * 2;
                Console.SetCursorPosition(x, y);
                Console.Write("@");
            }
        }
    }
}