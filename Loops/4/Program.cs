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
            Console.WriteLine("Enter other number: ");
            int k = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;
            int factorialL = 1;

            if (k < n)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;
                }
                for (int i = 1; i <= k; i++)
                {
                    factorialK *= i;
                }

                for (int i = 1; i <= n - k; i++)
                {
                    factorialL *= i;
                }
                Console.WriteLine(factorialN * factorialK / factorialL);
            }
            else
            {
                Console.WriteLine("Your second number must be less!");
            }
        }
    }
}