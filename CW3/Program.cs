using System;

namespace CW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int randomNum = newNum(1, 101);
            int count = 1;
            while (true)
            {
                Console.Write("I am thinking of a number between 0 and 100:");
                int input = Convert.ToInt32(Console.ReadLine());
                
                if (input < randomNum)
                {
                    Console.WriteLine("Low, try again.");
                    ++count;
                    continue;
                }
                else if (input > randomNum)
                {
                    Console.WriteLine("High, try again.");
                    ++count;
                    continue;
                }
                else
                {
                    Console.WriteLine("You guessed it! The number was {0}!", randomNum);
                    Console.WriteLine("It took you {0} {1}.\n", count,
                                      count == 1 ? "try" : "tries");
                    break;
                }
            }
        }
        static int newNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}

