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

            Console.WriteLine("\nProblem 3: Power Of 2");
            PowerOf2.TakeInput();
            PowerOf2.DisplayResult();

            Console.WriteLine("\nProblem 4: Harmonic Number");
            HarmonicNumber.TakeInput();
            HarmonicNumber.DisplayResult();

            Console.WriteLine("\nProblem 5: Factors");
            PrimeFactors.TakeInput();
            PrimeFactors.DisplayResult();
        }
    }
}
