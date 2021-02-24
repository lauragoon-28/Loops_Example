using System;

namespace Loops_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your lucky # >>");
            string answer = Console.ReadLine();
            int luckyNumber;

            while (int.TryParse(answer , out luckyNumber) == false)
            {
                Console.WriteLine("Sorry you entered an invalid integer. Please enter another #");
                answer = Console.ReadLine();
            }

            Console.WriteLine("Yay you entered an integer");
        }
    }
}
