using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafe.Repository;


namespace Cafe.Repository
{
    public class MenuRepository

    {
        List<Menu> _menuList = new List<Menu>();


        // add new meal to the database

        public void AddMealToDatabase(Menu meal)
        {
            _menuList.Add(meal);
        }

        //prints database to console
        public List<Menu> ViewWholeMenu()
        {
            return _menuList;
        }

        //search menu by the meal name
        public Menu GetMealByName(string mealName)
        {
            foreach (Menu x in _menuList)
            {
                if (mealName.ToUpper() == x.NameOfMeal.ToUpper())
                {
                    return x;
                }
            }
            return null;
        }










        //Delete item from the menu


        public bool DeleteMenuItem(Menu meal)
        {
            int allItemsOnMenu = _menuList.Count();
            _menuList.Remove(meal);
            if (allItemsOnMenu == _menuList.Count())
            {
                return false;
            }
            return true;
        }







        public void SeedMenuData()
        {
            string[] chickenTacoIngredients = {"Chicken", "Cheese", "Tomatoes",
        "Hot Sauce", "Lettuce"};

            string[] beefTacoIngredients = {"Beef", "Cheese", "Tomatoes",
        "Hot Sauce", "Lettuce"};

            string[] chickenOnTheBeachIngredients = { "Chicken", "Cheese", "Rice", "More Cheese", "Love" };


            Menu chickenTaco = new Menu("Chicken Taco Meal", 1, "Two Chicken Tacos in flour tortillas with a side of beans and rice", 6.75m, chickenTacoIngredients);

            Menu beefTaco = new Menu("Beef Taco Meal", 2, "Two Beef Tacos in flour tortillas with a side of beans and rice", 5.90m, beefTacoIngredients);

            Menu chickenOnTheBeach = new Menu("Chicken on The Beach", 3, "Chicken and rice with cheese sauce", 7.15m, chickenOnTheBeachIngredients);


            Menu[] menuArr = { chickenTaco, beefTaco, chickenOnTheBeach };

            foreach (Menu x in menuArr)
            {
                AddMealToDatabase(x);
            }

        }

    }//class
}//namespace




