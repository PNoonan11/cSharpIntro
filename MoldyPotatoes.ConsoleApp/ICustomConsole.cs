using MoldyPotatoes.Repository;

namespace MoldyPotatoes.ConsoleApp
{
    public interface ICustomConsole
    {
        void EnterATitle();
        void EnterDirectorName();
        void EnterStars();
        void GenreSelectionMenu();
        string GetUserInput();
        int GetUserInputInt();
        void PressAnyKeyToContinue();
        void PrintMainMenu();
        void PrintMovie(Movie film);
        void PrintMovies(List<Movie> films);
        void RatingSelectionMenu();
        void Search();
        void EnterATitleToDelete();
        void MovieSuccessfullyDeleted(Movie film);
        void SomethingWentWrong();
        void MovieNotFound(string movieTitle);
        void ExitMessage();

    }
}