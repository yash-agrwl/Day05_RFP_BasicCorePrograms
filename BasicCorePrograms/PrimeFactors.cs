using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PrimeFactors
    {

        static int InputNum;

        public static void TakeInput()
        {
            Console.Write("Enter the Number: ");
            InputNum = Convert.ToInt32(Console.ReadLine());
        }

        public static void Calculate()
        {
            int incrementor = 2, num = InputNum;
            while(num > 1)
            {
                if (num % incrementor == 0)
                {
                    Console.Write(incrementor + " ");
                    num /= incrementor;
                }
                else
                    incrementor++;
            }
        }

        public static void DisplayResult()
        {
            Console.Write("The Prime Factors Of " + InputNum + " Are: ");
            Calculate();
            Console.WriteLine();
        }
    }
}
