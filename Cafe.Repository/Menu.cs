using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Repository
{
    
        public class Menu
        {
            public string NameofMeal { get; set; } 
            public int MealNumber { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public List<string> Ingredients { get; set; }

            public Menu(string nameOfMeal, int mealNumber, string description, decimal price, List<string> ingredients)
            {
                NameofMeal = nameOfMeal;
                MealNumber = mealNumber;
                Description = Description;
                Price = price;
                Ingredients = ingredients;
            }

            public Menu() { }

        }
}