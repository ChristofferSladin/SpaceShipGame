using SpaceShipGame;

class GameLoop
{
    public void Game()
    {
        var obj = new Apples();
        var cha = new Snake();

        obj.Spawn();

        cha.Player();
    }
}
