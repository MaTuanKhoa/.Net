/*The game must include the following information: Name, Genre, Year of production, Description.
    (1) Allow users to create new games
    (2) Allow users to display the list of all games
    (3) Allow users to remove a game from the list
 */

namespace VideoGameManagement;
    internal class GameManager
    {
        static void Main(string[] args)
        {
            Controllers.MainController mainController = new Controllers.MainController();
            mainController.Run();
        }
    }

