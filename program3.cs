using System;

namespace Under_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0 && a < 10)
            {
                Console.WriteLine("The number is even and less than 10: TRUE!");
            }
            else
            {
                Console.WriteLine("The number does not meet the condition: FALSE!");
            }
        }
    }
