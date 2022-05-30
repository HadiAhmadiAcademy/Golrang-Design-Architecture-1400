using System;
using DecoratorSample.Model;

namespace DecoratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var component = CreateComponent();

            Console.Write(component.SayHello());

            Console.ReadLine();
        }

        private static IComponent CreateComponent()
        {
            return new BorderDecorator(new ConcreteComponent());
        }
    }
}
