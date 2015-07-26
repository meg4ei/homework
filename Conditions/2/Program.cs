using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your points: ");
            int points = int.Parse(Console.ReadLine());

            if (points >= 1 && points <= 9)
            {
                if (points >= 1 && points <= 3)
                {
                    Console.Write("Your New Extra Points are: ");
                    Console.WriteLine(points + 5);
                    Console.WriteLine();
                }
                else if (points >= 4 && points <= 6)
                {
                    Console.Write("Your New Extra Points are: ");
                    Console.WriteLine(points * 12);
                    Console.WriteLine();
                }
                else if (points >= 7 && points <= 9)
                {
                    Console.Write("Your New Extra Points are: ");

                    int sum = points * 50;
                    Console.WriteLine(sum / 3);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Your choice is not correct! :( ");
                Console.WriteLine();
            }
        }
    }
}