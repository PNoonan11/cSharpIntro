namespace AnimalShelter.Repository
{
    public class Animal
    {
        //PROPERTIES - use pascal casing
public string AnimalName {get; set;}
public DietType TypeOfDiet {get; set;}
public int Age {get; set;}
public string Species {get; set;}
        //CONSTRUCTORS

            //full Constructor
                public Animal(string animalName, DietType typeOfDiet, int age, string species)
                {
                    AnimalName = animalName;
                    TypeOfDiet = typeOfDiet;
                    Age = age;
                    Species = species;
                }
            //Empty Constructor
            public Animal(){}
    }

    //ENUMS - enums are placed in the namespace level, not within a class. 
public enum DietType {Herbivore, Omnivore, Carnivore};
}