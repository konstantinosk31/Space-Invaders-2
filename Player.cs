using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Space_Invaders_2
{
    class Player
    {
        public bool alive = true;
        public char icon = 'W';
        public void MoveLeft() { }
        public void MoveRight() { }
        public void Shoot() { }
        public void getInput()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    MoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    MoveRight();
                    break;
                case ConsoleKey.Spacebar:
                    Shoot();
                    break;
            }
        }
        public void Shoot() { }
    }
}
