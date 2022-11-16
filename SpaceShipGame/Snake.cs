namespace SpaceShipGame
{
    class Snake
    {
        public List<string> SnakesLegnth;
        public int X { get; set; }
        public int Y { get; set; }

        public void Display(int x, int y, string s)
        {
            while (true)
            {
                if (Y <= 0)
                {
                    Y = 1;
                    break;
                }
                if (Y > 29)
                {
                    Y--;
                }

                if (X <= 0)
                {
                    X = 1;
                    break;
                }
                if (X >= 118) 
                {
                    X--;
                }
                break;


            }

            
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(s);


        }
        public void Player()
        {
            int x = 45;
            int y = 15;
            Console.CursorVisible = false;

            while (true)
            {
                string s = "¤";


                var move = Console.ReadKey(true).Key;

                switch (move)
                {
                    case
                        ConsoleKey.W:
                        {

                            Y--;
                            Display(X, Y, s);

                            break;
                        }

                    case
                    ConsoleKey.S:
                        {

                            Y++;

                            Display(X, Y, s);

                            break;
                        }

                    case
                    ConsoleKey.A:
                        {

                            X--;

                            Display(X, Y, s);

                            break;
                        }

                    case
                    ConsoleKey.D:
                        {

                            X++;

                            Display(X, Y, s);

                            break;
                        }
                }
            }
        }
    }
}
