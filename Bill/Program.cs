using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill
{
    class Demo
    {
       public int price_of_item=Int32.Parse(Console.ReadLine());
        public int quantity = Int32.Parse(Console.ReadLine());
        public Demo()
        {

        }
        

    }
    class Cash : Demo
    {
        int cash;
       public void get_cash()
        {
            int notes_of_two_thousand = Int32.Parse(Console.ReadLine());
            int notes_of_five_hundred = Int32.Parse(Console.ReadLine());
            int notes_of_hundred = Int32.Parse(Console.ReadLine());
            int notes_of_fifty = Int32.Parse(Console.ReadLine());
            int notes_of_ten = Int32.Parse(Console.ReadLine());
             cash = notes_of_two_thousand * 2000 + notes_of_five_hundred * 500 + notes_of_hundred * 100 + notes_of_fifty * 50 + notes_of_ten * 10;


        }
        public void display()
        {
            get_cash();
            if (cash == price_of_item * quantity)
            {
                Console.WriteLine("Clear");
            }
            else
            {
                Console.WriteLine("Need to pay:"+(price_of_item * quantity - cash));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cash cash = new Cash();
            cash.display();
            Console.ReadKey();
        }
    }
}
