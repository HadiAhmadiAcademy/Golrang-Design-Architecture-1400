using System;
using FixtureSetupDemo.Model;
using Xunit;

namespace FixtureSetupDemo
{
    public class UnitTest1
    {
        private Order order;
        public UnitTest1()
        {
            this.order = new Order();
        }

        [Fact]
        public void Test1()
        {
            this.order.Counter++;
        }

        [Fact]
        public void Test2()
        {
            this.order.Counter++;
        }
    }
}
