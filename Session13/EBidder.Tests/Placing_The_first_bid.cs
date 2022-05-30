using System;
using EBidder.Model.Auctions;
using EBidder.Model.Bids;
using FluentAssertions;
using Xunit;

namespace EBidder.Tests
{
    public class When_placing_The_first_bid
    {
        [Fact]
        public void bid_with_appropriate_amount_will_be_the_winning_bid()
        {
            var auction = new Auction(1000);
            var bid = new Bid(1100);

            auction.PlaceBid(bid);

            auction.WinningBid.Should().BeEquivalentTo(bid);
        }

        [Fact]
        public void bid_cant_be_smaller_than_starting_price()
        {
            var auction = new Auction(1000);
            var bid = new Bid(900);

            Action placingBid = () => auction.PlaceBid(bid);

            placingBid.Should().Throw<InvalidBidException>();
        }

    }
}
