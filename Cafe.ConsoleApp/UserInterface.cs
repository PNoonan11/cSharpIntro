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
            _console.EnterNewMealName();
            string nameOfMeal = _console.GetUserInput();

            _console.EnterNewMealNumber();
            int mealNumber = Int32.Parse(_console.GetUserInput());

            _console.EnterNewMealDescription();
            string description = _console.GetUserInput();

            _console.EnterNewMealPrice();
            decimal price = Convert.ToDecimal(_console.GetUserInput());

            _console.EnterNewMealIngredientAmount(); //Hate this, but couldnt get it to work correctly if I split it up into singular methods :sadface:
            string inputToInt = _console.GetUserInput();
            int ingredientAmount = Convert.ToInt32(inputToInt);
            _console.EnterNewMealIngredient();
            string userInput = _console.GetUserInput();
            string[] ingredients = new string[ingredientAmount];
            for (int i = 0; i <= ingredients.Length; i++)
            {
                _console.EnterNewMealIngredient();
                ingredients[i] = _console.GetUserInput();
            }

            _console.DoneAddingIngredients();
            _console.PressAnyKeyToContinue();


            Menu newMeal = new Menu(nameOfMeal, mealNumber, description, price, ingredients);

            _repo.AddMealToDatabase(newMeal);
            _console.MealAddedToDatabase();
            _console.PressAnyKeyToContinue();
        }
        public void ViewWholeMenu()
        {
            List<Menu> wholeMenu = _repo.ViewWholeMenu();

            _console.DisplayMenu(wholeMenu);

            _console.PressAnyKeyToContinue();
        }

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

        private void InvalidInputReturnToMainMenu()
        {
            _console.InvalidInput();
            _console.PressAnyKeyToContinue();
            _console.PrintMainMenu();
        }

        public string[] CreateNewMenuItemIngredients(string ingredient)
        {
            string[] ingredients = new string[5];
            string userInput = _console.GetUserInput();
            while (userInput != "n")
            {
                for (int i = 0; i < ingredients.Length; i++)
                {
                    ingredients[i] = ingredient;

                    //CreateNewMenuItemIngredients(userInput);
                }
            }

            _console.DoneAddingIngredients();
            _console.PressAnyKeyToContinue();
            return ingredients;
        }

        public string[] AddAdditionalIngredientsSwitchCase(string userInput)
        {


            _console.EnterNewMealIngredient();
            string input = _console.GetUserInput();
            CreateNewMenuItemIngredients(input);
            return null;
        }
        // public string[] AddingIngredients()
        // {
        //     _console.EnterNewMealIngredient();
        //     string userInputOne = _console.GetUserInput();
        //     string[] ingredients = CreateNewMenuItemIngredients(userInputOne);
        //     return ingredients;
        //     _console.AddAdditionalIngredientsToMeal();
        //     string userInput = _console.GetUserInput();
        //     AddAdditionalIngredientsSwitchCase(userInput);

        // }






















    }










}
