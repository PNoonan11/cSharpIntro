using Outings.Repository;
namespace Outings.ConsoleApp
{

    public interface ICustomConsole
    {
        void Clear();
        void ErrorHasOccurred(Exception e);
        void EventTypeSelectionMenu();
        string GetUserInput();
        void InvalidInput();
        void ListAllOutings(List<OutingList> outing);
        void NewOutingAdded(OutingList outing);
        void NewOutingAttendeeCount();
        void NewOutingCostPerPerson();
        void NewOutingDateEntry();
        void OutingTypeSelectorTotalCost();
        void PressAnyKeyToContinue();
        void PrintMainMenu();
        void PrintMenu(OutingList outing);
        void TitleArt();
        void TotalCostOfAllOutings(decimal cost);
        void TotalCostOfAllOutingsByType(decimal cost);
    }

}