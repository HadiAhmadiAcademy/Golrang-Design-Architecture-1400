using System;
using Loans.Domain.Model;

namespace Loans.Domain.Tests.Unit.TestUtils
{
    internal class LoanRequestBuilder
    {
        private DateTime _issueDate;
        private long _amount;
        private long _paybackMonths;
        public LoanRequestBuilder()
        {
            this._issueDate = DateTime.Now.AddDays(7);
            this._amount = 100;
            this._paybackMonths = 12;
        }

        public LoanRequestBuilder WithIssueDate(DateTime issueDate)
        {
            this._issueDate = issueDate;
            return this;
        }
        public LoanRequestBuilder WithAmount(long amount)
        {
            this._amount = amount;
            return this;
        }
        public LoanRequestBuilder WithPaybackMonths(long paybackMonths)
        {
            this._paybackMonths = paybackMonths;
            return this;
        }
        public LoanRequest Build()
        {
            return new LoanRequest(this._issueDate, this._amount, this._paybackMonths);
        }
    }
}