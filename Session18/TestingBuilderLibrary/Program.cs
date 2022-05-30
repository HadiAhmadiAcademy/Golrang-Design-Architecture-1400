using System;
using System.Linq;
using FizzWare.NBuilder;

namespace TestingBuilderLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = Builder<Student>.CreateListOfSize(10)
                .All()
                .With(a=> a.Firstname = Faker.Name.First())
                .With(a=> a.Lastname = Faker.Name.Last())
                .With(a=> a.Address = Faker.Address.StreetAddress())
                .With(a=> a.Email = Faker.Internet.Email())
                .Build()
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student.Id);
                Console.WriteLine(student.Firstname);
                Console.WriteLine(student.Lastname);
                Console.WriteLine(student.Address);
                Console.WriteLine(student.Email);
                Console.WriteLine("-------------");
            }
            
            Console.ReadLine();
        }
    }
}
