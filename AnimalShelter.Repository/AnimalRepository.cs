using System;


namespace AnimalShelter.Repository
{
    public class AnimalRepository
    {
        //FAKE DATABASE
        private List<Animal> _animalListDB = List<Animal>();


        //CRUD METHODS

        //CREATE
            //create Animal
            public void AddAnimalToDatabase(Animal animal)
            {
                _animalListDB.Add(animal);
            }
        //Read

            //GetAllAnimals
            public List<Animal> GetAllAnimalsFromList()
            {
                return _animalListDB
            }
            //GetAnimal
            public Animal GetAnimal(string animalSearch)
            {
                foreach (Animal animal in _animalListDB)
                {
                    if ( animal.AnimalName.ToUpper() == animalSearch.ToUpper())
                    {
                        return animal;
                    }
                }
                return null;
            }
        //Update
            //UpdateAnimal
            public bool UpdateAnimal(Animal animal)
            {
                foreach (Animal existingAnimals in _animalListDB)
                {
                    if (existingAnimals.animalName.ToUpper() == animal.AnimalName.ToUpper())
                    {
                        existingAnimals.animalName = animal.animalName;
                        existingAnimals.typeOfDiet = animal.typeOfDiet;
                        existingAnimals.age = animal.age;
                        existingAnimals.species = animal.species;
                    }
                }
            }
        //Delete

            //DeleteAnimal






        //SEED DATA
        public void SeedAnimalData()
        {
            Animal tucker = new Animal("Tucker", DietType.Carnivore, 1, "Dog");
            Animal zelda = new Animal("Zelda", DietType.Carnivore, 3, "Cat");
            Animal finn = new Animal("Finn", DietType.Carnivore, 1, "Praying Mantis");

            Animal[] animalArr = {tucker, zelda, finn};

            foreach (Animal x in animalArr)
            {
            AddAnimalToDatabase(x);
            }
        }
    }
}