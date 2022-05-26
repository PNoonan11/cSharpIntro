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
                            "3. Cost of Outing by Type. \n");
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
            Console.WriteLine($"The total cost of this Outing Type is: ${cost}");
        }







        public void InvalidInput()
        {
            Console.WriteLine("Invalid input received, returning to main menu...");
        }





    }//class
}//namespace