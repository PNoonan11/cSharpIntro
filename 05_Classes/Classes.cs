using System.Runtime.CompilerServices;
namespace _05_Classes
{

public class Car
{
    public string Manufacturer {get; set;}
    public string Model {get; set;}
    public int SafetyRating {get; set;}
    public float EngineSize {get; set;}
    public int HighwayFuelConsumption {get; set;}

public Car(string manufacturer, string model, int safetyRating, float engineSize, int mpg) //Constructors always share the name of the class they are constructing. 
            {
                Manufacturer = manufacturer;
                Model = model;
                SafetyRating = safetyRating;
                EngineSize = engineSize;
                HighwayFuelConsumption = mpg;
            }
        //EMPTY CONSTRUCTOR
        public Car() {}
}





    public class Movie
    {
        //Class OBJECT
        public string Title {get; set;} //PROPERTY - Capital letters
        public string DirectorName {get; set;}
        public int Stars {get; set;}
        public Rating MovieRating{get; set;}
        public Genre MovieGenre {get; set;}


//FULL CONSTRUCTOR 
        public Movie(string title, string directorName, int stars, Rating movieRating, Genre movieGenre) //Constructors always share the name of the class they are constructing. 
            {
                Title = title;
                DirectorName = directorName;
                Stars = stars;
                MovieRating = movieRating;
                MovieGenre = movieGenre;
            }
        //EMPTY CONSTRUCTOR
        public Movie() {}



    }


    public enum Rating {G, PG, PG_13, R, MA}
   public enum Genre {Action, Comedy, Drama, Horror, Romance, RomCom, Thriller, SciFi_Fantasy}

}
 
