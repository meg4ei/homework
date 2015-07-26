using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int b = int.Parse(Console.ReadLine());

            int c = 0;
            int result = 1;

            if (a > b)
            {
                c = b;
            }
            else if (a < b)
            {
                c = a;
            }
            else if (a == b)
            {
                c = a;
            }

            for (int i = 1; i <= c; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    result = i;
                }
            }
            Console.WriteLine("The largest divider is : " + result);
        }
    }
}
