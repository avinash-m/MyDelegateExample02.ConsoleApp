using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegateExample02.ConsoleApp
{
    public delegate void PersonDetails(string info);

    class Program
    {

        static void City(string name)
        {
            Console.WriteLine($"{name} lives in US.");
        }

        static void Age(string name)
        {
            Console.WriteLine($"{name} is 12 years old");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            PersonDetails pd = Age;
            pd += City;    // multicasting delegate

            pd(name);

        }
    }
}
