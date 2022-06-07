using System;
using Loans.Domain.Model.LoanRequests;

namespace Loans.Application
{
    public class LoanRequestService          //Application Service
    {
        private readonly ILoanRequestRepository _repository;
        public LoanRequestService(ILoanRequestRepository repository)
        {
            _repository = repository;
        }
        public void Place()
        {
            var loanRequest = new LoanRequest(DateTime.Now, 1000, 12);
            _repository.Add(loanRequest);
        }
        public void Confirm()
        {
            
        }
    }
}
