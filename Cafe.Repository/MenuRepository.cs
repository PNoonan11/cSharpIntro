using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafe.Repository;

namespace Cafe.Repository
{
    public class MenuRepository
    {


        List<string> chickenTacoIngredients = new List<string>() {"Chicken", "Cheese", "Tomatoes",
        "Hot Sauce", "Lettuce"};
        List<string> beefTacoIngredients = new List<string>() {"Beef", "Cheese", "Tomatoes",
        "Hot Sauce", "Lettuce"};
        List<string> chickenOnTheBeachIngredients = new List<string>() { "Chicken", "Cheese", "Rice", "More Cheese", "Love" };





        public void SeedMenuData()
        {

            Menu chickenTaco = new Menu("Chicken Taco Meal", 1, "Two Chicken Tacos in flour tortillas with a side of beans and rice", 6.75m, chickenTacoIngredients);

            Menu beefTaco = new Menu("Beef Taco Meal", 2, "Two Beef Tacos in flour tortillas with a side of beans and rice", 5.90m, beefTacoIngredients);

            Menu chickenOnTheBeach = new Menu("Chicken on The Beach", 3, "Chicken and rice with cheese sauce", 7.15m, chickenOnTheBeachIngredients);


            Menu[] menuArr = { chickenTaco, beefTaco, chickenOnTheBeach };

            foreach (Menu x in menuArr)
            {
                //AddMenuToDatabase(x);
            }

        }

    }//class
}//namespace




