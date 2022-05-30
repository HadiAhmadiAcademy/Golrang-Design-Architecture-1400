using System;

namespace Variance
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFactory<Animal> factory = new Factory<Cat>();
            //IPrinter<Circle> printer = new Printer<Shape>();

            //Action<Circle> show = ShowShape;
            //show.Invoke(new Circle());

            Console.WriteLine("Hello World!");
        }

        public static void ShowShape(Shape shape)
        {

        }

    }

    #region Covariant
    public class Animal
    {
    }
    public class Cat : Animal
    {
    }

    public interface IFactory<out T> where T : new()
    {
        T Create();
        //void Put(T animal);
    }
    public class Factory<T> : IFactory<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
    #endregion

    #region Contravariant

    public class Shape
    {

    }
    public class Circle : Shape
    {

    }

    public interface IPrinter<in T>
    {
        void Print(T shape);
    }
    public class Printer<T> : IPrinter<T>
    {
        public void Print(T shape)
        {
            Console.WriteLine("....");
        }
    }

    #endregion

}
