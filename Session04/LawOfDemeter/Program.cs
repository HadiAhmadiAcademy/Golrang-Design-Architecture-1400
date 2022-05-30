using System;
using System.Collections.Generic;
using System.Linq;

namespace LawOfDemeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = CreateOrder();

            var nameOfAllProduct = order.Items.Select(a => a.Product.Name).ToList();

            Console.WriteLine("Hello World!");
        }

        private static Order CreateOrder()
        {
            return new Order()
            {
                Items = new List<OrderItem>()
                {
                    new OrderItem()
                    {
                        Product = new Product("Bag")
                    },
                    new OrderItem()
                    {
                        Product = new Product("Show")
                    }
                }
            };
        }
    }

    public class Order
    {
        public List<OrderItem> Items { get; set; }
    }
    public class OrderItem
    {
        public Product Product { get; set; }
    }
    public class Product
    {
        public string Name { get; set; }
        public Product(string name)
        {
            Name = name;
        }
    }
}
