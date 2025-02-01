using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassDemo
{
    public struct Event
    {
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public Event(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public double GetDuration()
        {
            return EndDate.Subtract(StartDate).TotalDays;
        }

        public bool IsOverlapping(Event otherEvent)
        {
            if (this.StartDate >= otherEvent.StartDate && this.StartDate < otherEvent.EndDate) return true;
            else if(otherEvent.StartDate >= this.StartDate && otherEvent.StartDate < this.EndDate) return true;
            else return false;
        }
    }

    public class Exercise
    {
        public void TestEvents()
        {
            Event event1 = new Event(DateTime.Today, DateTime.Today.AddDays(9));
            Event event2 = new Event(DateTime.Today.AddDays(-5), DateTime.Today.AddDays(-2));
            Console.WriteLine("Event 1 Duration: " + event1.GetDuration() + " days");
            Console.WriteLine("Event 2 Duration: " + event2.GetDuration() + " days");
            Console.WriteLine("Events Overlap: " + event1.IsOverlapping(event2));

        }
    }
}
