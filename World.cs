using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Space_Invaders_2
{
    class World
    {
        public bool GameOver = false;
        public const int width = 15;
        public const int height = 15;
        /*public char[,] map =
        {
            {' ', ' ', ' ', '@', '@', '@', '@', '@', '@', '@', '@', '@', ' ', ' ', ' '},
            {' ', ' ', ' ', '@', '@', '@', '@', '@', '@', '@', '@', '@', ' ', ' ', ' '},
            {' ', ' ', ' ', '@', '@', '@', '@', '@', '@', '@', '@', '@', ' ', ' ', ' '},
            {' ', ' ', ' ', '@', '@', '@', '@', '@', '@', '@', '@', '@', ' ', ' ', ' '},
            {' ', ' ', ' ', '@', '@', '@', '@', '@', '@', '@', '@', '@', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', '█', '█', '█', ' ', '█', '█', '█', ' ', '█', '█', '█', ' ', ' '},
            {' ', ' ', '█', ' ', '█', ' ', '█', ' ', '█', ' ', '█', ' ', '█', ' ', ' '},
            {' ', ' ', '█', ' ', '█', ' ', '█', ' ', '█', ' ', '█', ' ', '█', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', 'W', ' ', ' ', ' ', ' ', ' ', ' ', ' '}
        };*/
        public int wallX1 = 1, wallX2 = 35, wallY1 = 1, wallY2 = 25;
        public void ShowWall()
        {
            for(int y = wallY1+1; y < wallY2; y++)
            {
                Console.SetCursorPosition(wallX1, y);
                Console.Write("|");
            }
            for (int y = wallY1+1; y < wallY2; y++)
            {
                Console.SetCursorPosition(wallX2, y);
                Console.Write("|");
            }
            for (int x = wallX1+1; x < wallX2; x++)
            {
                Console.SetCursorPosition(x, wallY1);
                Console.Write("-");
            }
            for (int x = wallX1+1; x < wallX2; x++)
            {
                Console.SetCursorPosition(x, wallY2);
                Console.Write("-");
            }
        }
        public int ghCntX = 10, ghCntY = 5;
        public Ghost[,] ghostMap;
        public bool ghDirection; //0 == to left, 1 == to right
        public void MoveGhosts()
        {
            if(this.ghDirection == false) //direction == left
            {
                if (this.ghostMap[1, 1].x <= wallX1 + 1) { //hits left wall
                    for (int y = 1; y <= ghCntY; y++)
                    {
                        for (int x = 1; x <= ghCntX; x++)
                        {
                            if (this.ghostMap[y, x].y >= wallY2 - 1) GameOver = true; //hits down wall
                            else this.ghostMap[y, x].y++; //move down
                        }
                    }
                    this.ghDirection = !this.ghDirection;
                    MoveGhosts();  //move right
                }
                else
                {
                    for (int y = 1; y <= ghCntY; y++)
                    {
                        for (int x = 1; x <= ghCntX; x++)
                        {
                            this.ghostMap[y, x].x--; //move left
                        }
                    }
                }
            }
            else //direction == right
            {
                if (this.ghostMap[1, ghCntX].x >= wallX2 - 1) //hits right wall
                {
                    for (int y = 1; y <= ghCntY; y++)
                    {
                        for (int x = 1; x <= ghCntX; x++)
                        {
                            if (this.ghostMap[y, x].y >= wallY2 - 1) GameOver = true; //hits down wall
                            else this.ghostMap[y, x].y++; //move down
                        }
                    }
                    this.ghDirection = !this.ghDirection;
                    MoveGhosts();  //move left
                }
                else
                {
                    for (int y = 1; y <= ghCntY; y++)
                    {
                        for (int x = 1; x <= ghCntX; x++)
                        {
                            this.ghostMap[y, x].x++; //move right
                        }
                    }
                }
            }
        }
    }
}