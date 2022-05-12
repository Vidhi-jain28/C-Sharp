using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tollbooth
{
    class Toll
    {
        int cars;
        int amount;
        public Toll()
        {
            cars = 0;
            amount = 0;
        }
        public void payingCar()
        {
            cars++;
            amount += 50;
        }
        public void nopayCar()
        {
            cars++;
        }
        public void display()
        {
            Console.WriteLine("cars=" + cars);
            Console.WriteLine("total amount=" + amount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Toll t = new Toll();
            bool flag = true;
            while (flag)
            {
                string c = Console.ReadLine();
                if (c == "p")
                {
                    t.payingCar();
                }
                else if (c == "n")
                {
                    t.nopayCar();
                }
                else if (c == "q")
                {
                    flag = false;
                    t.display();
                    break;

                }
            }
            Console.ReadKey();
        }
    }
}
