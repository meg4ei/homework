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
            Console.WriteLine("Enter a playing card : ");
            string a = (Console.ReadLine());
            switch (a) 
            {
                case "2" : Console.WriteLine ("Your card is correct ! :)");break;
                case "3": Console.WriteLine("Your card is correct ! :)"); break;
                case "4": Console.WriteLine("Your card is correct ! :)"); break;
                case "5": Console.WriteLine("Your card is correct ! :)"); break;
                case "6": Console.WriteLine("Your card is correct ! :)"); break;
                case "7": Console.WriteLine("Your card is correct ! :)"); break;
                case "8": Console.WriteLine("Your card is correct ! :)"); break;
                case "9": Console.WriteLine("Your card is correct ! :)"); break;
                case "10": Console.WriteLine("Your card is correct ! :)"); break;
                case "a": Console.WriteLine("Your card is correct ! :)"); break;
                case "A": Console.WriteLine("Your card is correct ! :)"); break;
                case "q": Console.WriteLine("Your card is correct ! :)"); break;
                case "Q": Console.WriteLine("Your card is correct ! :)"); break;
                case "J": Console.WriteLine("Your card is correct ! :)"); break;
                case "j": Console.WriteLine("Your card is correct ! :)"); break;
                case "K": Console.WriteLine("Your card is correct ! :)"); break;
                case "k": Console.WriteLine("Your card is correct ! :)"); break;
                default: Console.WriteLine("Your card isn't correct ! :( "); break;
            }
        }
    }
}
