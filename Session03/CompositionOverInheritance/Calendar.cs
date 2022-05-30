using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionOverInheritance
{
    //Decorator Pattern

    public interface ICalendar
    {
        void Now();
    }

    public class Calendar : ICalendar
    {
        public void Now()
        {
            Console.WriteLine($"Today is : {DateTime.Now.Date}");
        }
    }

    public class FrameOfCalendar : ICalendar
    {
        private readonly ICalendar _targetCalendar;
        public FrameOfCalendar(ICalendar targetCalendar)
        {
            _targetCalendar = targetCalendar;
        }
        public void Now()
        {
            Console.WriteLine("****************");
            _targetCalendar.Now();
            Console.WriteLine("****************");
        }
    }

    public class ColorfulCalendar : ICalendar
    {
        private readonly ICalendar _targetCalendar;
        public ColorfulCalendar(ICalendar targetCalendar)
        {
            _targetCalendar = targetCalendar;
        }
        public void Now()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            _targetCalendar.Now();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }



    //public class CalendarWithFrame : Calendar
    //{
    //    public override void Now()
    //    {
    //        Console.WriteLine("*************");
    //        base.Now();
    //        Console.WriteLine("*************");
    //    }
    //}
    //public class ColorfulCalendar : CalendarWithFrame
    //{
    //    public override void Now()
    //    {
    //        Console.ForegroundColor = ConsoleColor.Yellow;
    //        base.Now();
    //        Console.ForegroundColor = ConsoleColor.White;
    //    }
    //}
}
