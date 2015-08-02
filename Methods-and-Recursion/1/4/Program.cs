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
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine();

                NumIsEvenIsOdd(num);
                Console.WriteLine();
            }

        }

        static void NumIsEvenIsOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("is Even");
            }
            else
            {
                Console.WriteLine("is Odd");
            }
            }
        }
    }

