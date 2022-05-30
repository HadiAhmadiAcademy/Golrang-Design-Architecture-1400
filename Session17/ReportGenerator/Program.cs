using System;

namespace ReportGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var reportMaker = new ReportMaker(new HtmlGenerator());

            Console.WriteLine("Hello World!");
        }
    }
}
