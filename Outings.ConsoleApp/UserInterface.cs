using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outings.Repository;

namespace Outings.ConsoleApp
{
    public class UserInterface
    {
        ICustomConsole _console;
        OutingsRepository _repo = new OutingsRepository();

        EventType outingTypeStored;
        bool isRunning = true;

        public UserInterface(ICustomConsole lang)
        {
            _console = lang;
        }

        public void Run()
        {
            //ASCII art on program run
            _console.TitleArt();

            _repo.SeedOutingData();
            while (isRunning)
            {
                OutingListMainMenu();
            }
        }

        //main menu switch case
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
                    InvalidInputReturnToMainMenu();
                    break;
            }
        }

        //show all outings stored in DB
        private void ViewAllOutings()
        {
            List<OutingList> allOutings = _repo.ViewOutingList();
            _console.ListAllOutings(allOutings);
            _console.PressAnyKeyToContinue();
            _console.Clear();
        }

        //returns total cost of all outings.
        private void TotalCostOfAllOutings()
        {
            try
            {
                _console.Clear();
                decimal totalCost;
                List<OutingList> allOutings = _repo.ViewOutingList();
                totalCost = _repo.OutingsTotalCost(allOutings);
                _console.TotalCostOfAllOutings(totalCost);
                _console.PressAnyKeyToContinue();
                _console.Clear();
            }
            catch (Exception e)
            {
                _console.ErrorHasOccurred(e);
            }
        }


        //returns cost of outings with user selected type
        private void TotalCostOfAllOutingsByType()
        {
            try
            {
                _console.Clear();
                _console.OutingTypeSelectorTotalCost();
                string selectedOuting = _console.GetUserInput();
                TypeOfOutingSelectorMenu(selectedOuting);
                List<OutingList> outingsByType = _repo.GetOutingsByType(outingTypeStored);
                _console.ListAllOutings(outingsByType);
                decimal totalCost = _repo.OutingsTotalCost(outingsByType);
                _console.TotalCostOfAllOutingsByType(totalCost);
                _console.PressAnyKeyToContinue();
                _console.Clear();
            }
            catch (Exception e)
            {
                _console.ErrorHasOccurred(e);
            }
        }

        // added to make the main menu reachable without just restarting the whole program.
        public void OutingListMainMenu()
        {
            _console.PrintMainMenu();
            string userInput = _console.GetUserInput();
            MainMenuSelection(userInput);

        }


        //Creating a new outing to add to the database.
        private void AddNewOuting()
        {
            try
            {
                _console.Clear();

                //create new outing - eventtype data
                _console.EventTypeSelectionMenu();
                string userInput = _console.GetUserInput();
                EventType? typeOfEvent = EventSelection(userInput);

                //create new outing - number of attendees data
                _console.NewOutingAttendeeCount();
                int numberOfAttendees = Convert.ToInt32(_console.GetUserInput());

                //create new outing - date entry data
                _console.NewOutingDateEntry();
                string date = _console.GetUserInput();

                //create new outing - cost per person data
                _console.NewOutingCostPerPerson();
                string costToDecimal = _console.GetUserInput();
                decimal costPerPerson = Convert.ToDecimal(costToDecimal);

                //create new outing - calculates total cost based on attendees and cost per person.
                decimal totalEventCost = CalculateTotalCostForOuting(numberOfAttendees, costPerPerson);

                OutingList newOuting = new OutingList(typeOfEvent, numberOfAttendees, date, costPerPerson, totalEventCost);

                _repo.AddOutingToDatabase(newOuting);
                _console.NewOutingAdded(newOuting);
                _console.PressAnyKeyToContinue();
            }
            catch (Exception e)
            {
                _console.ErrorHasOccurred(e);
            }
        }






        //switch case for EVENT TYPE when creating a new outing
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




        //Error handling
        private void InvalidInputReturnToMainMenu()
        {
            try
            {
                _console.InvalidInput();
                _console.PressAnyKeyToContinue();
                OutingListMainMenu();
            }
            catch (Exception e)
            {
                _console.ErrorHasOccurred(e);
            }
        }

        //SWTICH CASE FOR SORTING BY EVENT TYPE
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