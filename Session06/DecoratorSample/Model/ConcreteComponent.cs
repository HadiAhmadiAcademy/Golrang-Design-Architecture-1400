using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample.Model
{
    public interface IComponent
    {
        string SayHello();
    }

    public class ConcreteComponent : IComponent
    {
        public string SayHello()
        {
            return "Hello world";
        }
    }

    public class BorderDecorator : IComponent
    {
        private readonly IComponent _component;
        public BorderDecorator(IComponent component)
        {
            _component = component;
        }
        public string SayHello()
        {
            var output = _component.SayHello();
            return "=======================" +
                   "\n\r|                         |" +
                   "\n\r|                         |" +
                   $"\n\r|        {output}      |" +
                   "\n\r|                         |" +
                   "\n\r|                         |" +
                   "\n\r=======================";
        }
    }

    //public class BorderedComponent : Component
    //{
    //    public override string SayHello()
    //    {
    //        var output = base.SayHello();
    //        return "=======================" +
    //               "\n\r|                         |" +
    //               "\n\r|                         |" +
    //               $"\n\r|        {output}      |" +
    //               "\n\r|                         |" +
    //               "\n\r|                         |" +
    //               "\n\r=======================";
    //    }
    //}
}
