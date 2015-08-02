using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a number: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Search Index of number: ");
            int m = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                if (m == myArray[j])
                {
                    Console.WriteLine();
                    Console.WriteLine("The Index is: " + j);
                    break;
                }
            }
        }
    }
}