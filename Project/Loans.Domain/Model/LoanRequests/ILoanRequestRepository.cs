namespace Loans.Domain.Model.LoanRequests
{
    public interface ILoanRequestRepository
    {
        void Add(LoanRequest loanRequest);
    }
}