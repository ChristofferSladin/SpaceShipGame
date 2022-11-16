using SpaceShipGame;

class HighScore
{
    private string Name { get; set; }
    private int Score { get; set; }

    public void SaveScore()
    {
        var score = new Snake();

        Console.Write("Save your score by entering your name: ");
        Name = Console.ReadLine();
        Score = score.Count;

        File.AppendAllText("HighScore.txt", $"{Name}: {Score}" + Environment.NewLine);
    }
    public void ShowHighScore()
    {
        foreach (var line in File.ReadLines("HighScore.txt"))
        {
            Console.Write(line);
        }
    }
}

