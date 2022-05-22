using System;
namespace CalculateTip
{
    public class UserInterface
    {
        TipRepo _tipRepo = new TipRepo(); //newing up instance of TipRepo


        public void Start(){
            AskUserForTotalBill();

            decimal totalBill = Convert.ToDecimal(Console.ReadLine());//Converts string that is input, to a decimal. 
            decimal totalBillWithTipIncluded = _tipRepo.CalculateFifteenPercentTip(totalBill);

            Console.WriteLine("Your total bill with a 15% tip is " + totalBillWithTipIncluded + "!!!!");
            Console.ReadKey();
        }

        private void AskUserForTotalBill(){
        Console.Write("What was your total bill? : $");
        }

    }
}