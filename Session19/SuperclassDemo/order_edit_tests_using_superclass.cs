using System;
using FluentAssertions;
using SuperclassDemo.Model;
using Xunit;

namespace SuperclassDemo
{
    public abstract class order_edit_tests_using_superclass
    {
        [Fact]
        public void edit_is_not_allowed()
        {
            Order order = CreateNonEditableOrder();

            Action edit =()=> order.Edit();

            edit.Should().Throw<InvalidOperationException>();
        }

        protected abstract Order CreateNonEditableOrder();
    }

    public class When_order_is_confirmed : order_edit_tests_using_superclass
    {
        protected override Order CreateNonEditableOrder()
        {
            var order = new Order();
            order.Confirm();
            return order;
        }
    }

    public class When_order_is_rejected : order_edit_tests_using_superclass
    {
        protected override Order CreateNonEditableOrder()
        {
            var order = new Order();
            order.Reject();
            return order;
        }
    }
}