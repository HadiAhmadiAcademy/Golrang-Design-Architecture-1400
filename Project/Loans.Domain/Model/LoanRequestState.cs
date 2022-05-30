using System;

namespace Loans.Domain.Model
{
    public abstract class LoanRequestState
    {
        public abstract bool CanEdit();
        public abstract LoanRequestState Confirm();
        public abstract LoanRequestState Reject();
    }
    public class DraftState : LoanRequestState
    {
        public override bool CanEdit() => true;
        public override LoanRequestState Confirm() => new ConfirmedState();
        public override LoanRequestState Reject() => new RejectedState();
    }
    public class ConfirmedState : LoanRequestState
    {
        public override bool CanEdit() => false;
        public override LoanRequestState Confirm() => throw new InvalidOperationException();
        public override LoanRequestState Reject() => throw new InvalidOperationException();
    }
    public class RejectedState : LoanRequestState
    {
        public override bool CanEdit() => false;
        public override LoanRequestState Confirm() => throw new InvalidOperationException();
        public override LoanRequestState Reject() => throw new InvalidOperationException();

    }
}