using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoldyPotatoes.Repository;

namespace MoldyPotatoes.ConsoleApp
{

    public class CustomConsole : ICustomConsole
    {
        //SINGLE RESPONSIBILITY
        //Methods that print things to the console. 
        public void PrintMainMenu()
        {
            Console.WriteLine("1. Create New Movie.\n" +
                            "2. View All Movies.\n" +
                            "3. Get Movie By Title.\n" +
                            "4. Search by Title.\n" +
                            "5. Edit a Movie.\n" +
                            "6. Delete a Movie.\n" +
                            "7. Exit.\n");

        }

        public string GetUserInput()
        {
            return Console.ReadLine();
        }
        public int GetUserInputInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public void EnterATitle()
        {
            Console.Write("Enter a Title:  ");
        }
        public void EnterATitleToDelete()
        {
            Console.Write("Enter a Title to DELETE:  ");
        }
        public void MovieSuccessfullyDeleted(Movie film)
        {
            Console.Write($"{film.Title} Successfully Deleted!");
        }
        public void Search()
        {
            Console.Write("Search:");
        }
        public void EnterDirectorName()
        {
            Console.Write("Enter Director's Name:  ");
        }
        public void GenreSelectionMenu()
        {
            Console.WriteLine("1. Action.\n" +
                            "2. Comedy.\n" +
                            "3. Drama.\n" +
                            "4. Romance.\n" +
                            "5. RomCom.\n" +
                            "6. Thriller.\n" +
                            "7. SciFi_Fantasy.\n");
        }
        public void RatingSelectionMenu()
        {
            Console.WriteLine("1. G.\n" +
                            "2. PG.\n" +
                            "3. PG-13.\n" +
                            "4. R.\n" +
                            "5. MA.\n");
        }

        public void EnterStars()
        {
            Console.Write("Enter number of Stars our of 10:");
        }

        public void PrintMovie(Movie film)
        {
            Console.WriteLine($"Title: {film.Title}\n" +
                            $"Director: {film.DirectorName}\n" +
                            $"Rating: {film.MovieRating}\n" +
                            $"Genre: {film.MovieGenre}\n" +
                            $"Stars: {film.Stars}/10\n");
        }
        public void PrintMovies(List<Movie> films)
        {
            foreach (Movie x in films)
            {
                PrintMovie(x);
            }
        }

        public void PressAnyKeyToContinue()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        public void SomethingWentWrong()
        {
            Console.WriteLine("Something went wrong....");
        }

        public void MovieNotFound(string movieTitle)
        {
            Console.WriteLine(String.Format("{0} not found", movieTitle));
        }

        public void ExitMessage()
        {
            Console.WriteLine("Hate to see you go, seeya later.");
        }

    } //class
}//namespace