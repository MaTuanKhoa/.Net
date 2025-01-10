using VideoGameManagement.Model;
using VideoGameManagement.Repositories;
using VideoGameManagement.Views;

namespace VideoGameManagement.Controllers;

internal class GameController
{
    private GameRepository gameRepository;
    private GameView gameView;

    public GameController()
    {
        gameRepository = new GameRepository();
        gameView = new GameView();
    }

    public void AddGame()
    {
        Game newGame = gameView.CreateNewGame();
        gameRepository.AddGame(newGame);
        Console.Clear();
    }

    public void DisplayAllGames()
    {
        Console.Clear();
        Console.WriteLine("=== LIST OF GAME ===");
        var games = gameRepository.GetAllGames();
        var i = 1;
        foreach (var game in games)
        {
            Console.WriteLine($"The {i} Game:");
            gameView.DisplayGame(game);
            i++;
        }
        Console.WriteLine("=== PRESS ANY KEY TO CONTINUE ===");
        Console.ReadKey();
        Console.Clear();
    }

    public void RemoveGame(string gameName)
    {
        gameRepository.RemoveGame(gameName);
    }
}

