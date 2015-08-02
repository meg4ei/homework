using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.Write("Press a number a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Press a number b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Press a number c: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int result1 = Multi(a, b, c);
                Console.Write("The result of multiplication is:");
                Console.WriteLine(result1);
                Console.WriteLine();
            }
        }
        private static int Multi(int num, int num1, int numb2)
        {
            int result = num * num1 * numb2;
            return result;
        }
    }
}
