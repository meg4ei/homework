using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text: ");
            string a = Console.ReadLine();

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int m = 1;

            for (int i = 0; i <=n; i++)
            {
                m = i;             
            }

            Console.WriteLine();
            Console.WriteLine("The symbol is: " + a[m]);
            Console.WriteLine();
           
        }
    }
}
