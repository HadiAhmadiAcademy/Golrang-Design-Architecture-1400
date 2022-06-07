using System;
using System.Collections.Generic;
using Loans.Domain.Model.LoanRequests;

namespace Loans.Persistence
{
    public class InMemoryLoanRequestRepository : ILoanRequestRepository
    {
        private List<LoanRequest> _records = new List<LoanRequest>();
        public void Add(LoanRequest loanRequest)
        {
            _records.Add(loanRequest);
        }
    }
}
