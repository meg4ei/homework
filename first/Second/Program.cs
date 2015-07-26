using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("The sum is: "+ c);
        }
    }
}
