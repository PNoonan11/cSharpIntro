using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outings.Repository;
namespace Outings.ConsoleApp
{
    public class CustomConsole
    {
        public void PrintMainMenu()
        {
            Console.WriteLine("Komodo Outings Database\n\n" +
                            "1. View All Outings.\n" +
                            "2. Total Cost of All Outing Types. \n" +
                            "3. Cost of Outing by Type. \n" +
                            "4. Add Outing To Database.");
        }
        public void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public string GetUserInput()
        {
            return Console.ReadLine();
        }
        public void ListAllOutings(List<OutingList> outing)
        {
            foreach (OutingList x in outing)
            {
                PrintMenu(x);
            }
        }
        public void PrintMenu(OutingList outing)
        {
            Console.WriteLine($"Type Of Event: {outing.TypeOfEvent}\n" +
                            $"Number of Attendees: {outing.NumberOfAttendees}\n" +
                            $"Date of Event: {outing.Date}\n" +
                            $"Cost Per Person : ${outing.CostPerPerson}\n" +
                            $"Total Cost of the Outing: ${outing.TotalEventCost}\n");
        }

        public void OutingTypeSelectorTotalCost()
        {
            Console.WriteLine("Which outing type would you like to view total cost for?\n" +
                            "1. Golf Outings.\n" +
                            "2. Bowling Outings.\n" +
                            "3. Amusement Park Outings.\n" +
                            "4. Concert Outings.\n");
        }

        public void TotalCostOfAllOutingsByType(decimal cost)
        {
            Console.WriteLine($"The total cost of this Outing Type is: ${cost}\n");
        }
        public void TotalCostOfAllOutings(decimal cost)
        {
            Console.WriteLine($"The total cost of all Outings: ${cost}\n");
        }

        public void EventTypeSelectionMenu()
        {
            Console.WriteLine("Select a Type for the new outing.\n");
            Console.WriteLine("1. Golf.\n" +
                            "2. Bowling.\n" +
                            "3. Amusement Park.\n" +
                            "4. Concert.\n");
        }
        public void NewOutingAttendeeCount()
        {
            Console.WriteLine("How many people attended the outing?:");
        }

        public void NewOutingDateEntry()
        {
            Console.WriteLine("Enter the date of the Outing(mm/dd/yy):");
        }

        public void NewOutingCostPerPerson()
        {
            Console.WriteLine("Please enter the cost PER PERSON for the outing:");
        }
        public void NewOutingAdded(OutingList outing)
        {
            Console.WriteLine($"Your new {outing.TypeOfEvent} outing has been added to the database!");
        }





        public void Clear()
        {
            Console.Clear();
        }
        public void InvalidInput()
        {
            Console.WriteLine("Invalid input received, returning to main menu...");
        }






    }//class
}//namespace