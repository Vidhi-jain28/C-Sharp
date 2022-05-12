using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Demo
    {
        int day;
        int month;
        public Demo(int day, int month)
        {
            this.day = day;
            this.month = month;
        }
        public int daysInMonth()
        {
            int days = DateTime.DaysInMonth(2022, month);
            return days;
        }
        public int getDay()
        {
            return day;
        }
        public int getMonth()
        {
            return month;
        }
        public int nextDay()
        {
            int days = DateTime.DaysInMonth(2002, month);
            if (day == days)
            {
                return 1;
                month = (month + 1) % 13;
            }
            else
            {
                return day + 1;
            }
        }
        public string toString()
        {
            return month + "/" + day;
        }
        public int absoluteDay()
        {
            int days = DateTime.DaysInMonth(2022, 2);
            if (days == 29)
                return 366;
            else
                return 365;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo(5, 5);
            Console.WriteLine(d.daysInMonth());
            Console.WriteLine(d.nextDay());
            Console.WriteLine(d.getMonth());
            Console.WriteLine(d.toString());
            Console.WriteLine(d.absoluteDay());

            Console.ReadKey();
        }
    }
}
