using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafe.Repository;

namespace Cafe.ConsoleApp
{
    public class UserInterface
    {
        MenuRepository _repo = new MenuRepository();
        CustomConsole _console = new CustomConsole();

        bool isRunning = true;

        public void Run()
        {
            _repo.SeedMenuData();

            while (isRunning)
            {
                _console.PrintMainMenu();
                string userInput = _console.GetUserInput();
                MainMenuSelection(userInput);
            }
        }

        private void MainMenuSelection(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    CreateNewMenuItem();
                    break;
                case "2":
                    DeleteMenuItem();
                    break;
                case "3":
                    ViewWholeMenu();
                    break;
                default:
                    InvalidInputReturnToMainMenu();
                    break;
            }
        }

        private void CreateNewMenuItem()
        {
            _console.ClearTheConsole();
            try
            {
                //Collects name of the new menu item.
                _console.EnterNewMealName();
                string nameOfMeal = _console.GetUserInput();


                //Collects number of the new menu item.
                _console.EnterNewMealNumber();
                int mealNumber = Int32.Parse(_console.GetUserInput());



                //Collects menu number for new menu item. 
                _console.EnterNewMealDescription();
                string description = _console.GetUserInput();


                //Collects price of new menu item.
                _console.EnterNewMealPrice();
                decimal price = Convert.ToDecimal(_console.GetUserInput());




                //Collects string of ingredients from user for new menu item. 
                _console.EnterNewMealIngredientAmount(); //Hate this, but couldnt get it to work correctly if I split it up into singular methods :sadface:
                string inputToInt = _console.GetUserInput();
                int ingredientAmount = Convert.ToInt32(inputToInt);

                //sets array size for ingredients to get from user.
                string[] ingredients = new string[ingredientAmount];
                for (int i = 0; i < ingredientAmount;)
                {
                    _console.EnterNewMealIngredient();
                    string item = _console.GetUserInput();
                    ingredients[i] += item;
                    i++;
                }


                _console.DoneAddingIngredients();
                _console.PressAnyKeyToContinue();
                _console.ClearTheConsole();


                Menu newMeal = new Menu(nameOfMeal, mealNumber, description, price, ingredients);

                _repo.AddMealToDatabase(newMeal);
                _console.MealAddedToDatabase();
                _console.PressAnyKeyToContinue();
            }
            catch (Exception e)
            {
                _console.ErrorHasOccurred(e);
            }

        }

        //displays whole menu
        public void ViewWholeMenu()
        {
            _console.ClearTheConsole();
            List<Menu> wholeMenu = _repo.ViewWholeMenu();

            _console.DisplayMenu(wholeMenu);

            _console.PressAnyKeyToContinue();
        }

        //Delete an item from the menu

        private void DeleteMenuItem()
        {
            ViewWholeMenu();

            _console.EnterMenuItemToDelete();

            String menuItemToBeDeleted = _console.GetUserInput();

            Menu mealToDelete = _repo.GetMealByName(menuItemToBeDeleted);
            if (mealToDelete != null)
            {
                bool isSuccess = _repo.DeleteMenuItem(mealToDelete);

                if (isSuccess)
                {
                    _console.MenuItemSuccessfullyRemoved(mealToDelete);
                }
                else
                {
                    _console.AnErrorHasOccurred();
                }
            }
            else
            {
                _console.MealNotFound(menuItemToBeDeleted);
            }



        }

        // Invalid Input from user
        private void InvalidInputReturnToMainMenu()
        {
            _console.InvalidInput();
            _console.PressAnyKeyToContinue();
            _console.PrintMainMenu();
        }
    }

}
