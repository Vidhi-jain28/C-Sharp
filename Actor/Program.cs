using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actor
{
    class Person
    {
        public string name;
        public int number_of_eyes;
        public string color;
        public int debut_year;
        public Person()
        {

        }

    }
    class Actor : Person
    {
        public Actor(string name, int number_of_eyes, string color, int debut_year)
        {
            this.name = name;
            this.number_of_eyes = number_of_eyes;
            this.color = color;
            this.debut_year = debut_year;
        }
        public string toString()
        {
            return name + " is an Actor. He is " + color + ", has " + number_of_eyes + " eyes and debut in " + debut_year;
        }
    }
    class Actress : Person
    {
        public Actress(string name, int number_of_eyes, string color, int debut_year)
        {
            this.name = name;
            this.number_of_eyes = number_of_eyes;
            this.color = color;
            this.debut_year = debut_year;
        }
        public string toString()
        {
            return name + " is an Actress. She is " + color + ", has " + number_of_eyes + " eyes and debut in " + debut_year;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Actor actor = new Actor("Amitabh", 2, "Brown", 1996);
            Actress actress = new Actress("Hema", 2, "White", 1990);
            Console.WriteLine(actor.toString());
            Console.WriteLine(actress.toString());
            Console.ReadLine();
        }
    }
}
