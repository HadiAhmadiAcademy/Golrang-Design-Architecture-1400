namespace EBidder.Model.Bids
{
    public class Bid
    {
        public long Amount { get; private set; }
        //..............
        //..............
        //..............
        //..............
        public Bid(long amount)
        {
            Amount = amount;
        }
    }
}
