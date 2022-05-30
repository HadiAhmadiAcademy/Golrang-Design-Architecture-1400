using System;
using System.Collections.Generic;
using FluentAssertions;
using SuperclassDemo.Model;
using Xunit;

namespace SuperclassDemo
{
    public class order_edit_using_theories
    {
        [Theory]
        [MemberData(nameof(InvalidStatesForEditing))]
        public void edit_is_not_allowed_on_invalid_states(Action<Order> changeState)
        {
            var order = new Order();
            changeState.Invoke(order);

            Action edit =() => order.Edit();

            edit.Should().Throw<InvalidOperationException>();
        }

        public static IEnumerable<object[]> InvalidStatesForEditing =>
            new List<object[]>
            {
                new Action<Order>[] { a=> a.Confirm() },
                new Action<Order>[] { a=> a.Reject() },
            };

    }
}