using AnimalShelter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;



namespace AnimalShelter.ConsoleApp
{
    public class UserInterface
    {
        //FIELDS

        //bool isRunning for our whileloop
            private bool isRunning = true;
        //new up instance of REPO class stored in variable.

        private AnimalRepository _repo = new AnimalRepository();

        //METHODS

            //Run
                public void Run()
                {
                    _repo.SeedAnimalData();

                    while(isRunning)
                    {
                        PrintMainMenu();

                        string input = GetUserInput();
                        
                        
                        
                        //user input switch case - UserInputSwitchCase(input);
                    }
                }
            //PrintMainMenu
                private void PrintMainMenu()
                {
                    Console.WriteLine("Hello World.");
                }
            //GetUserInput
            private string GetUserInput()
                {
                    return Console.ReadLine();
                }
            //CRUD Methods in the context of the UserInterface.
    }
}