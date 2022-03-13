using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Computation Of Basic Core Programs\n");

            Console.WriteLine("Problem 1: Flip Coin");
            FlipCoin.TakeInput();
            FlipCoin.Check();
            FlipCoin.DisplayResult();

            Console.WriteLine("\nProblem 2: Leap Year");
            LeapYear.TakeInput();
            LeapYear.DisplayResult();
        }
    }
}
