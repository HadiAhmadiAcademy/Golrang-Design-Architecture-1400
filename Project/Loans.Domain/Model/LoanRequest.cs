﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans.Domain.Model
{
    public class LoanRequest
    {
        public DateTime IssueDate { get; private set; }
        public long Amount { get; private set; }
        public long PayBackMonths { get; private set; }
        public LoanRequestState State { get; private set; }

        public LoanRequest(DateTime issueDate, long amount, long payBackMonths)
        {
            if (amount <= 0) throw new Exception(); //TODO: don't throw general exception

            this.IssueDate = issueDate;
            this.Amount = amount;
            this.PayBackMonths = payBackMonths;
            this.State = new DraftState();
        }
        public void ChangeAmount(long amount)
        {
            if (this.State.CanEdit())
                this.Amount = amount;
            else
                throw new InvalidOperationException();
        }
        public void Confirm()
        {
            this.State = this.State.Confirm();
        }

        public void Reject()
        {
            this.State = this.State.Reject();
        }
    }
}
