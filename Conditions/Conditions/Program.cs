using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To integer enter 1");
            Console.WriteLine("To double enter 2");
            Console.WriteLine("To string enter 3");

            Console.WriteLine();
            Console.Write("Enter your number: ");

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a integer number: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + (a + 1));
                    break;
                case 2:
                    Console.Write("Enter a double number: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + (b + 1));
                    break;
                case 3:
                    Console.Write("Enter a string text: ");
                    string c = Console.ReadLine();
                    Console.WriteLine("Result: " + c + "*");
                    break;
                default:
                    Console.WriteLine("You didn't select number 1, 2 or 3!");
                    break;
            } Console.WriteLine();
        }
    }
}
