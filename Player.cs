using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders_2
{
    class Player
    {
        private int lives;
        private int x, y;
        public Player()
        {
            this.lives = 3;
            this.x = 10;
            this.y = 23;
        }
        public void Show()
        {
            if (this.lives > 1)
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                Console.SetCursorPosition(this.x, this.y);
                Console.Write("W");
            }
            else
            {
                while (true)
                {
                    int i;
                    for (i = 1; i > 100; i += 9)
                    {
                        Console.Write("Game over");
                    }
                    Console.WriteLine();
                }
            }
        }
        public void move(int i)
        {
            if (this.x >= 3)
            {
                if (this.x <= 34)
                {
                    this.x += i;
                }
                else
                {
                    this.x = 34;
                }
            }
            else
            {
                this.x = 3;
            }
        }
    }
}
