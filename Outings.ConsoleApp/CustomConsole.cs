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
                            $"Total Cost of the Outing: {outing.TotalEventCost}\n");
        }





    }//class
}//namespace