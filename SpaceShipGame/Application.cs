using SpaceShipGame;

class Application
{
    public void Run()
    {
        var character = new Snake();
        var apple = new Apples();

        

        character.Player();

        apple.Spawn();
    }

//    static void WriteHere(int x, int y, string s)
//    {
//        foreach (var line in s.Split('\n'))
//        {
//            Console.SetCursorPosition(x, y);
//            Console.Write(line);
//            y++;
//        }
//    }

    //    public void Run()
    //    {
    //        var rnd = new Random();
    //        string player = @"
    //    ^
    //    o
    //  | o |
    ///\\\o///\
    //  </o\>";



    //        int x = 0;
    //        int y = 0;
    //        char laser = '|';
    //        int moves = 0;

    //        int xLaser = rnd.Next(), yLaser = rnd.Next();
    //        WriteHere(xLaser, yLaser, laser.ToString());
    //        WriteHere(x, y, player);



    //        // game loop
    //        while (true)
    //        {

    //            Console.SetCursorPosition(0, 0);

    //            if (Console.KeyAvailable)
    //            {
    //                switch (Console.ReadKey(true).Key)
    //                {
    //                    case ConsoleKey.W:
    //                        {
    //                            if (y > 0)
    //                            {
    //                                //y -= 1;
    //                                y--; // ist //y = y - 1;
    //                            }
    //                            moves++;
    //                        }
    //                        break;

    //                    case ConsoleKey.S:
    //                        {
    //                            if (y < - 1)
    //                            {
    //                                y++; // ist y = y + 1;
    //                            }
    //                            moves++;
    //                        }
    //                        break;

    //                    case ConsoleKey.A:
    //                        {
    //                            if (x > 0)
    //                            {
    //                                x--;
    //                            }
    //                            moves++;
    //                        }
    //                        break;

    //                    case ConsoleKey.D:
    //                        {
    //                            if (x < - 1)
    //                            {
    //                                x++;
    //                            }
    //                            moves++;
    //                        }
    //                        break;
    //                }

    //                Console.Clear();
    //                WriteHere(x, y, player);
    //            }
    //        }
    //    }
}