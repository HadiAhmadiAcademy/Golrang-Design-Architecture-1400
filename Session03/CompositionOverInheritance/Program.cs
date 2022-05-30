using System;
using Spectre.Console;

namespace CompositionOverInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalendar calendar = CreateCalendar();

            calendar.Now();
        }

        private static ICalendar CreateCalendar()
        {
            ICalendar calendar = new Calendar();
            //var needFrame = AnsiConsole.Ask<bool>("Do you need frames?");
            //if (needFrame)
            //{
            //    calendar = new FrameOfCalendar(calendar);
            //}

            calendar = new FrameOfCalendar(
                            new FrameOfCalendar(
                                    new FrameOfCalendar(new FrameOfCalendar(new ColorfulCalendar(calendar)))));
            return calendar;
        }
    }
}
