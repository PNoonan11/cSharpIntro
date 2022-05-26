using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outings.Repository;

namespace Outings.ConsoleApp
{
    public class UserInterface
    {
        OutingsRepository _repo = new OutingsRepository();
        CustomConsole _console = new CustomConsole();

        bool isRunning = true;

        public void Run()
        {
            _repo.SeedOutingData();
            while (isRunning)
            {
                _console.PrintMainMenu();
                string userInput = _console.GetUserInput();

            }
        }
        private void MainMenuSelection(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    ViewAllOutings();
                    break;
                case "2":
                    //TotalCostOfAllOutings();
                    break;
                case "3":
                    //TotalCostOfAllOutingsByType();
                    break;
                default:
                    // InvalidInputReturnToMainMenu();
                    break;
            }
        }
        private void ViewAllOutings()
        {
            List<OutingList> allOutings = _repo.ViewOutingList();
        }





















    }//class
}//namespace