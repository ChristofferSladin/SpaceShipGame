namespace SpaceShipGame
{

    class Snake
    {
        public List<string> SnakesLegnth { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string S => "¤";
        public int Count { get; set; }

        public bool CheckCollision()
        {
            var obj = new Apples();

            if (obj.xS == X && obj.yS == Y)
            {
                return true;
            }
            else return false;

        }


        public void Player()
        {
            Console.SetWindowSize(150, 35);

            X = 70;
            Y = 25;
            Console.CursorVisible = false;
            var show = new Utils();
            bool check;
            bool run = true;

            while (run)
            {
                var move = Console.ReadKey(true).Key;

                // här ska det vara en if / om kordinater krockar med befintliga, avsluta loopen == död, game over

                switch (move)
                {
                    case
                        ConsoleKey.W:
                        {

                            Y--;
                            if (Y < 1)
                                Y = 1;

                            check = CheckCollision();
                            show.Display(X, Y, S);

                            if (check == true)
                            {
                                Console.Clear();
                                run = false;
                            }
                            
                            else continue;

                            break;
                        }

                    case
                    ConsoleKey.S:
                        {

                            Y++;

                            if (Y > 38)
                                Y = 38;
                            check = CheckCollision();
                            show.Display(X, Y, S);

                            if (check == true)
                            {
                                Console.Clear();
                                run = false;
                            }
                            
                            else continue;

                            break;
                        }

                    case
                    ConsoleKey.A:
                        {

                            X--;

                            if (X < 1)
                                X = 1;
                            check = CheckCollision();
                            show.Display(X, Y, S);

                            if (check == true)
                            {
                                Console.Clear();
                                run = false;
                            }
                            
                            else continue;

                            break;
                        }

                    case
                    ConsoleKey.D:
                        {

                            X++;

                            if (X > 147)
                                X = 147;

                            check = CheckCollision();
                            show.Display(X, Y, S);

                            if (check == true)
                            {
                                Console.Clear();
                                run = false;
                            }
                            
                            else continue;

                            break;
                        }
                }
            }
        }
    }
}
