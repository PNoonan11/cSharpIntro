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
                    //CreateNewMenuItem();
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
            _console.PressAnyKeyToContinue();
        }

        private void InvalidInputReturnToMainMenu()
        {
            _console.InvalidInput();
            _console.PressAnyKeyToContinue();
            _console.PrintMainMenu();
        }







    }
}