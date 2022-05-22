using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoldyPotatoes.Repository
{
    public class MovieRepository
    {
        //EMPTY CONSTRUCTOR - dont really need this, but we will use later.
        public MovieRepository() { }

        //FAKE DB
        List<Movie> _movieDB = new List<Movie>();

        //CREATE
        public void AddMovieToDatabase(Movie movie)
        {
            _movieDB.Add(movie);
        }


        // READ
        public List<Movie> GetAllMovies()
        {
            return _movieDB;
        }

        public Movie GetMovieByTitle(string movieTitle)
        {
            foreach (Movie x in _movieDB)
            {
                if (movieTitle.ToUpper() == x.Title.ToUpper())
                {
                    return x;
                }
            }
            return null;
        }

        public List<Movie> GetMoviesByTitleSearch(string movieTitle)
        {
            List<Movie> movieList = new List<Movie>();
            foreach (Movie x in _movieDB)
            {
                if (x.Title.ToUpper().Contains(movieTitle.ToUpper()))
                {
                    movieList.Add(x);
                }
            }
            return movieList;
        }
        // UPDATE


        // DELETE
        public bool DeleteMovieFromDatabase(Movie movie)
        {
            int totalMoviesInDB = _movieDB.Count();

            _movieDB.Remove(movie);
            if (totalMoviesInDB == _movieDB.Count())
            {
                return false;
            }
            return true;
        }

        //SEED DATA METHOD
        public void SeedMovieData()
        {
            Movie up = new Movie("UP", "Ben Caplan",  Genre.Comedy, Rating.G, 7);
            Movie avengers = new Movie("Avengers", "Nate Humphries",  Genre.Action, Rating.PG_13, 8);
            Movie deathToSmoochy = new Movie("Death To Smoochy", "Tai Chandler",  Genre.Comedy, Rating.R, 8);
            Movie forrestGump = new Movie("Forrest Gump", "Darryl James",  Genre.Drama, Rating.PG_13, 9);

            Movie[] movieArr = { up, avengers, deathToSmoochy, forrestGump };

            foreach (Movie x in movieArr)
            {
                AddMovieToDatabase(x);
            }
        }
    }
}