using VideoGameManagement.Input;

namespace VideoGameManagement.Views;

internal class MainView
{
    private InputWord inputWord = new InputWord();

    public void ShowMainMenu()
    {
        Console.WriteLine("\n1. Add new game");
        Console.WriteLine("2. Display all games");
        Console.WriteLine("3. Remove a game");
        Console.WriteLine("4. Exit");
    }

    public int Choose()
    {
        return inputWord.GetValidInt("\n---> Enter your choice: ");
    }

    public string GetGameToRemove()
    {
        return inputWord.GetNonEmptyString("---> Enter Name of Game to Remove: ");
    }

    public void ShowMessage()
    {
        Console.Clear();
        Console.WriteLine("=== INVALID CHOICE - TRY AGAIN ===");
    }
}

