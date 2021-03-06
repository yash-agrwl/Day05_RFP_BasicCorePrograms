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

            Console.WriteLine("\nProblem 6: Division");
            Division.TakeInput();
            Division.DisplayResult();

            Console.WriteLine("\nProblem 7: Swap Two Numbers");
            SwapNumbers.TakeInput();
            SwapNumbers.DisplayResult();

            Console.WriteLine("\nProblem 8: Check Even Or Odd");
            EvenOdd.TakeInput();
            EvenOdd.DisplayResult();

            Console.WriteLine("\nProblem 9: Check Vowel Or Consonant");
            VowelOrConsonant.TakeInput();
            VowelOrConsonant.DisplayResult();

            Console.WriteLine("\nProblem 10: Find Largest Among Three Numbers");
            LargestNumber.TakeInput();
            LargestNumber.DisplayResult();
        }
    }
}
