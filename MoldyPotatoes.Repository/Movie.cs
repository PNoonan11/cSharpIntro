using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoldyPotatoes.Repository
{
    public class Movie
    {
        // PROPERTIES
        public string Title { get; set; }
        public string DirectorName { get; set; }
        public Genre? MovieGenre { get; set; }
        public Rating? MovieRating { get; set; }
        public int Stars { get; set; }
        public bool IsKidFriendly 
        { 
            get
            {
                if(this.MovieRating == Rating.G || this.MovieRating == Rating.PG)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }

        // CONSTRUCTOR
        public Movie(string title, string directorName, Genre? movieGenre, Rating? movieRating, int stars)
        {
            Title = title;
            DirectorName = directorName;
            MovieGenre = movieGenre;
            MovieRating = movieRating;
            Stars = stars;
        }
        // EMPTY CONSTRUCTOR
        public Movie() { }
    }

    // ENUMS
    public enum Genre { Action, Comedy, Drama, Romance, RomCom, Thriller, SciFi_Fantasy }
    public enum Rating { G, PG, PG_13, R, MA }
}