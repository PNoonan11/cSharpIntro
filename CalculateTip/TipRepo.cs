namespace CalculateTip
{
    public class TipRepo
    {
        public decimal CalculateFifteenPercentTip(decimal totalBill){
        decimal totalWithTip = (totalBill * 0.15m) + totalBill;

        return totalWithTip;
        }
    }
}