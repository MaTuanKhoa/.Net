using VideoGameManagement.Input;
using VideoGameManagement.Model;

namespace VideoGameManagement.Views;

internal class GameView
{
    public void DisplayGame(Game game)
    {
        Console.WriteLine(game.ToString());
    }

    private InputWord inputWord = new InputWord();

    public Game CreateNewGame()
    {
        Console.Clear();
        string name = inputWord.GetNonEmptyString("---> Enter the game name: ");
        string genre = inputWord.GetNonEmptyString("---> Enter the game genre: ");
        int year = inputWord.GetValidInt("---> Enter the year of production: ");
        string description = inputWord.GetNonEmptyString("---> Enter the game description: ");

        return new Game(name, genre, year, description);
    }
}

