using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders_2
{
    class Ghost
    {
        public bool isAlive;
        public int x, y;
        public Ghost(int y1, int x1)
        {
            this.isAlive = true;
            this.y = y1;
            this.x = x1;
        }
        public void Show()
        {
            if (this.isAlive == true)
            {
                Console.SetCursorPosition(this.x, this.y);
                Console.Write("@");
            }
        }
    }
}
