using System;

namespace SuperclassDemo.Model
{
    public class Order
    {
        public OrderState State { get; private set; }
        public Order()
        {
            this.State = new Draft();
        }

        public void Confirm()
        {
            this.State = new Confirmed();
        }
        public void Reject()
        {
            this.State = new Rejected();
        }
        public void Edit()
        {
            if (!this.State.CanEdit())
                throw new InvalidOperationException();
        }
    }

    public abstract class OrderState
    {
        public abstract bool CanEdit();
    }

    public class Draft : OrderState
    {
        public override bool CanEdit() => true;
    }
    public class Confirmed : OrderState
    {
        public override bool CanEdit() => false;

    }
    public class Rejected : OrderState
    {
        public override bool CanEdit() => false;

    }
}