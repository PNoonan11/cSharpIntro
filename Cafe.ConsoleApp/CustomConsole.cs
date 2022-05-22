using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafe.Repository;

namespace Cafe.ConsoleApp
{
    public class CustomConsole
    {
        public void PrintMainMenu()
        {
            Console.WriteLine("1. Create New Menu Item\n" +
                            "2. Delete Menu Item. \n " +
                            "3. View All Menu Items\n");
        }
        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public void PrintMenu(Menu meal)
        {
            Console.WriteLine($"Name of Meal: {meal.NameOfMeal}\n" +
                            $"Menu Number: {meal.MealNumber}\n" +
                            $"Description: {meal.Description}\n" +
                            $"Price: ${meal.Price}\n" +
                            $"Ingredients: {meal.Ingredients}\n");
        }
        public void DisplayMenu(List<Menu> meal)
        {
            foreach (Menu x in meal)
            {
                PrintMenu(x);
            }
        }

       
        public void PressAnyKeyToContinue()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }




    }
}