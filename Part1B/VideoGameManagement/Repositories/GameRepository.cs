
using VideoGameManagement.Views;

namespace VideoGameManagement.Repositories;

internal class GameRepository
{
    private List<Model.Game> games = new List<Model.Game>();

    public void AddGame(Model.Game game)
    {
        games.Add(game);
    }

    public List<Model.Game> GetAllGames()
    {
        return games;
    }

    public void RemoveGame(string gameName)
    {
        while (true)
        {
            var gameToRemove = games.Find(g => g.Name == gameName);
            if (gameToRemove != null)
            {
                games.Remove(gameToRemove);
            }
            else
            {
                Console.WriteLine($"=== REMOVE ALL GAME NAME '{gameName}' ===");
                break;
            }
        }
        Console.WriteLine("\n=== PRESS ANY KEY TO CONTINUE ===");
        Console.ReadKey();
        Console.Clear();
    }
}

