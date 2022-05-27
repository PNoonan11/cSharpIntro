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
                    TotalCostOfAllOutingsByType();
                    break;
                case "4":
                    AddNewOuting();
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
            decimal totalCost;
            List<OutingList> allOutings = _repo.ViewOutingList();
            totalCost = _repo.OutingsTotalCost(allOutings);
            _console.TotalCostOfAllOutings(totalCost);
            _console.PressAnyKeyToContinue();
        }



        private void TotalCostOfAllOutingsByType()
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

        private void AddNewOuting()
        {
            _console.Clear();
            _console.EventTypeSelectionMenu();
            string userInput = _console.GetUserInput();
            EventType? typeOfEvent = EventSelection(userInput);

            _console.NewOutingAttendeeCount();
            int numberOfAttendees = Convert.ToInt32(_console.GetUserInput());

            _console.NewOutingDateEntry();
            string date = _console.GetUserInput();

            _console.NewOutingCostPerPerson();
            string costToDecimal = _console.GetUserInput();
            decimal costPerPerson = Convert.ToDecimal(costToDecimal);


            decimal totalEventCost = CalculateTotalCostForOuting(numberOfAttendees, costPerPerson);

            OutingList newOuting = new OutingList(typeOfEvent, numberOfAttendees, date, costPerPerson, totalEventCost);

            _repo.AddOutingToDatabase(newOuting);
            _console.NewOutingAdded(newOuting);
            _console.PressAnyKeyToContinue();
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
                    return outingTypeStored = EventType.AmusementPark;
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

        private EventType? EventSelection(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    return EventType.Golf;
                case "2":
                    return EventType.Bowling;
                case "3":
                    return EventType.AmusementPark;
                case "4":
                    return EventType.Concert;
                default:
                    return null;
            }
        }


        private decimal CalculateTotalCostForOuting(int numberOfAttendees, decimal costPerPerson)
        {
            decimal x = numberOfAttendees;
            decimal totalCost = x * costPerPerson;
            return totalCost;
        }







    }//class
}//namespace