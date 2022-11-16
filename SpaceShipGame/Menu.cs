using SpaceShipGame;

class Menu
{
    public void ShowMenu()
    {
        var player = new Snake();


        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.SetCursorPosition(45, 5);
        Console.WriteLine("WELCOME TO THE MAIN MENU");
        
        Console.WriteLine("\n\n\n\n1. PLAY THE GAME\n2.HIGH SCORE\nQ. Exit");
        var sel = Console.ReadLine();

        while (true)
        {
            if (sel == "1")
            {
                Console.WriteLine("\n\nMove With Keys: A, S, W, D");

                player.Player();
            }
            if (sel == "2")
            {

            }
            if(sel.ToLower() == "q")
            {
                Console.WriteLine("Thank you for playing");
                break;
            }

        }
    }
}
