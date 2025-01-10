using VideoGameManagement.Views;

namespace VideoGameManagement.Controllers;
internal class MainController
{
    private MainView mainView;
    private GameController gameController;

    public MainController()
    {
        mainView = new MainView();
        gameController = new GameController();
    }

    public void Run()
    {
        bool exit = false;
        while (!exit)
        {
            mainView.ShowMainMenu();
            int choice = mainView.Choose();

            switch (choice)
            {
                case 1:
                    gameController.AddGame();
                    break;
                case 2:
                    gameController.DisplayAllGames();
                    break;
                case 3:
                    string gameToRemove = mainView.GetGameToRemove();
                    gameController.RemoveGame(gameToRemove);
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    mainView.ShowMessage();
                    break;
            }
        }
    }
}

