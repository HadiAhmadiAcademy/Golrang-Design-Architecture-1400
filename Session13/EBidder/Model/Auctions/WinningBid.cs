namespace EBidder.Model.Auctions
{
    public class WinningBid
    {
        public long Amount { get; private set; }
        public WinningBid(long amount)
        {
            Amount = amount;
        }
    }
}