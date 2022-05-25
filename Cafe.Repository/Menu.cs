using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Repository
{

    public class Menu
    {
        public string NameOfMeal { get; set; }
        public int MealNumber { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string[] Ingredients { get; set; }

        public Menu(string nameOfMeal, int mealNumber, string description, decimal price, string[] ingredients)
        {
            NameOfMeal = nameOfMeal;
            MealNumber = mealNumber;
            Description = description;
            Price = price;
            Ingredients = ingredients;
        }

        public Menu() { }

    }
}

