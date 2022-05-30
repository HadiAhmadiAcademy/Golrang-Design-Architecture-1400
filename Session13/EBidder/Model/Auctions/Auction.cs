using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EBidder.Model.Bids;

namespace EBidder.Model.Auctions
{
    public class Auction
    {
        public WinningBid WinningBid { get; private set; }
        public long StartingPrice { get; private set; }

        public Auction(long startingPrice)
        {
            StartingPrice = startingPrice;
        }
        public void PlaceBid(Bid bid)
        {
            if (this.WinningBid == null)
            {
                if (bid.Amount <= StartingPrice)  
                    throw new InvalidBidException();
                
                this.WinningBid = new WinningBid(bid.Amount);
            }
        }
    }
}