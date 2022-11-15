using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShipGame
{
    class MyTry
    {
        public int height = Console.BufferHeight;
        public int width = Console.BufferWidth;

        public void Display(int x, int y, string s)
        {
            while (true) 
            {
                if (y <= 0)
                {
                    y = 0;
                    break;
                }
                    
                if (x <= 0)
                {
                    x = 0;
                    break;
                }
                break;
            }

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine(s);

        }

        public void Player()
        {
            int x = 0;
            int y = 0;
            Console.CursorVisible = false;

            while (true)
            {
                string s = "|===0===|";


                var move = Console.ReadKey(true).Key;

                switch (move)
                {
                    case
                        ConsoleKey.W:
                        {

                            y--;
                            Display(x, y, s);

                            break;
                        }

                    case
                    ConsoleKey.S:
                        {

                            y++;

                            Display(x, y, s);

                            break;
                        }

                    case
                    ConsoleKey.A:
                        {

                            x--;

                            Display(x, y, s);

                            break;
                        }

                    case
                    ConsoleKey.D:
                        {

                            x++;

                            Display(x, y, s);

                            break;
                        }
                }
            }
        }
        public void Laser()
        {
            var space = Console.ReadKey(true).Key;

            switch (space)
            {
                case ConsoleKey.Spacebar:
                    {

                        break;
                    }
            }

        }
    }
}
