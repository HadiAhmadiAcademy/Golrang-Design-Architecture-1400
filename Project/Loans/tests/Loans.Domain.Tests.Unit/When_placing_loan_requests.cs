using System;
using FluentAssertions;
using Loans.Domain.Model;
using Loans.Domain.Tests.Unit.TestUtils;
using Xunit;

namespace Loans.Domain.Tests.Unit
{
    public class When_placing_loan_requests
    {
        [Fact]
        public void gets_placed_properly()
        {
            var issueDate = DateTime.Now.AddDays(1);
            var amount = 1000;
            var paybackMonths = 12;

            var request = new LoanRequestBuilder()
                .WithAmount(amount)
                .WithIssueDate(issueDate)
                .WithPaybackMonths(paybackMonths)
                .Build();

            request.Amount.Should().Be(amount);
            request.PayBackMonths.Should().Be(paybackMonths);
            request.IssueDate.Should().Be(issueDate);
        }

        [Fact]
        public void gets_placed_in_as_a_draft_request()
        {
            var request = new LoanRequestBuilder().Build();

            request.State.Should().BeOfType<DraftState>();
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void amount_of_loan_must_be_a_positive_number(long amount)
        {
            Action placingRequest = () => new LoanRequestBuilder()
                                             .WithAmount(amount)
                                             .Build();

            placingRequest.Should().Throw<Exception>();
        }
    }
}
