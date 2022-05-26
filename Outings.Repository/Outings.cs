using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outings.Repository
{
    public class OutingList
    {
        public EventType? TypeOfEvent { get; set; }
        public int NumberOfAttendees { get; set; }
        public string Date { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal TotalEventCost { get; set; }
        public OutingList(EventType? typeOfEvent, int numberOfAttendees, string date, decimal costPerPerson, decimal totalEventCost)
        {
            TypeOfEvent = typeOfEvent;
            NumberOfAttendees = numberOfAttendees;
            Date = date;
            CostPerPerson = costPerPerson;
            TotalEventCost = totalEventCost;
        }
        public OutingList() { }
    }






    public enum EventType
    {
        Golf, Bowling, AmusementPark, Concert
    }
}