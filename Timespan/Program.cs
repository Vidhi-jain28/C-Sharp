using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timespan
{
    class Span
    {
        int hours;
        int minutes;
        public Span(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }
        public int getHours()
        {
            return hours;
        }
        public int getMinutes()
        {
            return minutes;
        }
        public void add(int hours, int minutes)
        {
            this.minutes = (this.minutes + minutes) % 60;
            this.hours = this.hours + hours + this.minutes / 60;


        }
        public void add(Span s)
        {
            this.minutes = (this.minutes + s.minutes) % 60;
            this.hours = this.hours + s.hours + this.minutes / 60;

        }
        public float getTotalHours()
        {
            return hours + (minutes / 60f);

        }
        public string toString()
        {
            return this.hours + " Hours," + this.minutes + " Minutes.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Span span = new Span(1, 45);
            Console.WriteLine(span.getHours());
            Console.WriteLine(span.getMinutes());
            Span s = new Span(5, 40);
            span.add(s);
            Console.WriteLine(span.getHours() + " " + span.getMinutes());

            Console.ReadKey();
        }
    }
}
