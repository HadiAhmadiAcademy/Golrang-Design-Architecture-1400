using System;
using FluentAssertions;
using Xunit;

namespace NinjaXml.Tests
{
    public class UnitTest1
    {
        private class Customer
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
        }
        private class Order
        {
            public long OrderId { get; set; }
            public Customer Customer { get; set; }
        }


        [Fact]
        public void returns_empty_string_on_null_object()
        {
            var actual = NinjaXmlSerializer.Serialize(null);

            actual.Should().BeEmpty();
        }

        [Fact]
        public void serializing_flat_objects()
        {
            var customer = new Customer() { Firstname = "John",  Lastname = "Doe" };

            var expected = "<Customer>" +
                           "<Firstname>John</Firstname>" +
                           "<Lastname>Doe</Lastname>" +
                           "</Customer>";

            var actual = NinjaXmlSerializer.Serialize(customer);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Serializing_nested_objects()
        {
            var customer = new Customer() { Firstname = "John", Lastname = "Doe" };
            var order = new Order()
            {
                OrderId = 1000,
                Customer = customer
            };

            var expected = "<Order>" +
                           "<Customer>" +
                               "<Firstname>John</Firstname>" +
                               "<Lastname>Doe</Lastname>" +
                           "</Customer>" +
                           "<OrderId>1000</OrderId>" +
                           "</Order>";

            var actual = NinjaXmlSerializer.Serialize(order);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
