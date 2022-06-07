using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Loans.Domain.Model;
using Loans.Domain.Model.LoanRequests;
using Loans.Domain.Tests.Unit.TestUtils;
using Xunit;

namespace Loans.Domain.Tests.Unit
{
    public class When_loan_request_is_confirmed
    {
        private LoanRequest _loanRequest;
        public When_loan_request_is_confirmed()
        {
            _loanRequest = new LoanRequestBuilder().Build();
            _loanRequest.Confirm();
        }

        [Fact]
        public void request_is_not_editable()
        {
            Action edit = ()=> _loanRequest.ChangeAmount(1000);

            edit.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void request_cannot_be_rejected()
        {
            Action reject = () => _loanRequest.Reject();

            reject.Should().Throw<InvalidOperationException>();
        }
    }
}
