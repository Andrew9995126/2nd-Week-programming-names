using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_week_programming_names
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your first name: ");
            string name1 = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            string name2 = Console.ReadLine();

            Console.WriteLine($"This is your full name: {name1} {name2}");
            Console.ReadLine();
        }
    }
}
