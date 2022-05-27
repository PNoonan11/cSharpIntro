using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outings.Repository;
namespace Outings.Repository
{
    public class OutingsRepository
    {

        // This is the "database"
        List<OutingList> _outingDB = new List<OutingList>();

        // adding to "database"
        public void AddOutingToDatabase(OutingList outing)
        {
            _outingDB.Add(outing);
        }

        public List<OutingList> ViewOutingList()
        {
            return _outingDB;
        }

        //takes user input to sort outings by type. 
        public List<OutingList> GetOutingsByType(EventType? selectedOuting)
        {
            List<OutingList> outingsByType = new List<OutingList>();
            foreach (OutingList x in _outingDB)
            {
                if (selectedOuting == x.TypeOfEvent)
                {
                    outingsByType.Add(x);
                }
            }
            return outingsByType;
        }

        //calculates total cost for events 
        public decimal OutingsTotalCost(List<OutingList> listByOutingType)
        {
            decimal totalCost = 0m;
            foreach (OutingList x in listByOutingType)
            {
                totalCost += x.TotalEventCost;
            }
            return totalCost;
        }
        // public decimal OutingsPerPersonCost(List<OutingList> listByOutingType) //misread the prompt, but left this because it was the solution to the white board problem I missed. :( im an idiot
        // {
        //     decimal perPersonCost = 0m;
        //     foreach (OutingList x in listByOutingType)
        //     {
        //         perPersonCost += x.CostPerPerson;
        //     }
        //     return perPersonCost;
        // }



























        public void SeedOutingData()
        {
            OutingList sixFlags = new OutingList(EventType.AmusementPark, 74, "02 / 20 / 2019", 145.52m, 10768.48m);
            OutingList bowlingJanuary = new OutingList(EventType.Bowling, 18, "01 / 22 / 2019", 32.72m, 588.96m);
            OutingList bowlingFebruary = new OutingList(EventType.Bowling, 22, "02 / 20 / 2019", 34.81m, 765.82m);
            OutingList bowlingMarch = new OutingList(EventType.Bowling, 31, "03 / 12 / 2019", 25.11m, 778.41m);
            OutingList bowlingApril = new OutingList(EventType.Bowling, 24, "04 / 04 / 2019", 29.35m, 704.40m);
            OutingList golfJanuary = new OutingList(EventType.Golf, 7, "01 / 19 / 2019", 56.14m, 392.98m);
            OutingList golfMarch = new OutingList(EventType.Golf, 12, "03 / 06 / 2019", 49.22m, 590.64m);
            OutingList golfJune = new OutingList(EventType.Golf, 20, "06 / 28 / 2019", 41.19m, 823.80m);
            OutingList buschGardens = new OutingList(EventType.AmusementPark, 86, "04 / 22 / 2019", 99.52m, 8558.72m);
            OutingList wuTangClanConcert = new OutingList(EventType.Concert, 33, "07 / 11 / 2019", 55.24m, 1822.92m);
            OutingList atmosphereConcert = new OutingList(EventType.Concert, 27, "04 / 01 / 2019", 36.36m, 981.72m);





            OutingList[] outingsArr = { sixFlags, bowlingJanuary, bowlingFebruary, bowlingMarch, bowlingApril, golfJanuary, golfMarch, golfJune, buschGardens, wuTangClanConcert, atmosphereConcert };

            foreach (OutingList x in outingsArr)
            {
                AddOutingToDatabase(x);
            }
        }



    }//class
}//namespace