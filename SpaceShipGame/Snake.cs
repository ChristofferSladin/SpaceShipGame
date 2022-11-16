namespace SpaceShipGame
{

    class Snake
    {
        public List<string> SnakesLegnth { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string S => "¤";
        public int Count { get; set; }
       
        public void Player()
        {
            Console.SetWindowSize(150, 40);

            X = 70;
            Y = 25;
            Console.CursorVisible = false;
            var show = new Utils();

            while (true)
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

                            show.Display(X, Y, S);

                            break;
                        }

                    case
                    ConsoleKey.S:
                        {

                            Y++;

                            if (Y > 38)
                                Y = 38;

                            show.Display(X, Y, S);

                            break;
                        }

                    case
                    ConsoleKey.A:
                        {

                            X--;

                            if (X < 1)
                                X = 1;

                            show.Display(X, Y, S);

                            break;
                        }

                    case
                    ConsoleKey.D:
                        {

                            X++;

                            if (X > 147)
                                X = 147;

                            show.Display(X, Y, S);

                            break;
                        }
                }
            }
        }
    }
}
