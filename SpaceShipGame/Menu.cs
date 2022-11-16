using SpaceShipGame;

class Menu
{
    public void ShowMenu()
    {
        var player = new Snake();


        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(45, 5);
        Console.WriteLine("WELCOME TO THE MAIN MENU");
        
        Console.WriteLine("\n\n\n\n1. PLAY THE GAME\n2. HIGH SCORE\nQ. Exit");
        var sel = Console.ReadLine();

        while (true)
        {
            if (sel == "1")
            {
                Console.Clear();

                Console.SetCursorPosition(65, 5);
                Console.WriteLine("TO START PLAYING");
                Console.SetCursorPosition(61, 7);

                Console.WriteLine("MOVE WITH KEYS: A, S, W, D");

                player.Player();


            }
            if (sel == "2")
            {
                var show = new HighScore();

            }
            if(sel.ToLower() == "q")
            {
                Console.SetCursorPosition(45, 15);
                Console.WriteLine("THANK YOU FOR PLAYING\n");
                Console.SetCursorPosition(44, 18);
                Console.WriteLine("WE HOPE TO SEE YOU AGAIN");
                Console.ReadKey();
                break;
            }

        }
    }
}
