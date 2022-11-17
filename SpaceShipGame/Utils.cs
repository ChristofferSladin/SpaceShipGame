namespace SpaceShipGame
{
    class Utils
    {
        public void Display( int x, int y, string s)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine(s);
        }
    }
}
