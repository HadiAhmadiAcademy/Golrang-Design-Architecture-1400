using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseType x = new Subtype();

            try
            {
                x.DoSomething();
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
           
            Console.ReadLine();
        }
    }

    public abstract class BaseType
    {
        public virtual void DoSomething()
        {
            throw new MyCustomException();
        }
    }
    public class Subtype : BaseType
    {
        public override void DoSomething()
        {
            throw new MySpecializedCustomException();
        }
    }

    public class MyCustomException : Exception
    {

    }
    public class MySpecializedCustomException : MyCustomException
    {

    }
}
