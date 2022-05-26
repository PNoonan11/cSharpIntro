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
        EventType outingTypeStored;
        bool isRunning = true;

        public void Run()
        {
            _repo.SeedOutingData();
            while (isRunning)
            {
                OutingListMainMenu();
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
                    TotalCostOfAllOutings();
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
            _console.ListAllOutings(allOutings);
            _console.PressAnyKeyToContinue();
        }

        private void TotalCostOfAllOutings()
        {
            _console.OutingTypeSelectorTotalCost();
            string selectedOuting = _console.GetUserInput();
            TypeOfOutingSelectorMenu(selectedOuting);
            List<OutingList> outingsByType = _repo.GetOutingsByType(outingTypeStored);
            _console.ListAllOutings(outingsByType);
            decimal totalCost = _repo.OutingsTotalCost(outingsByType);
            _console.TotalCostOfAllOutingsByType(totalCost);
            _console.PressAnyKeyToContinue();
        }

        public void OutingListMainMenu()
        {
            _console.PrintMainMenu();
            string userInput = _console.GetUserInput();
            MainMenuSelection(userInput);

        }







        private EventType? TypeOfOutingSelectorMenu(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    return outingTypeStored = EventType.Golf;
                case "2":
                    return outingTypeStored = EventType.Bowling;

                case "3":
                    return outingTypeStored = EventType.Concert;
                case "4":
                    return outingTypeStored = EventType.Concert;
                default:
                    InvalidInputReturnToMainMenu();
                    return null;
            }
        }





        private void InvalidInputReturnToMainMenu()
        {
            _console.InvalidInput();
            _console.PressAnyKeyToContinue();
            OutingListMainMenu();
        }










    }//class
}//namespace