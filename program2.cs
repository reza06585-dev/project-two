namespace Multipleof7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 7 == 0)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    int result = number * 3;
                    Console.WriteLine($"Result: {result}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
    }
}