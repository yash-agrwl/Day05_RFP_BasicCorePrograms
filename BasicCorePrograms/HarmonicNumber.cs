using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {

        static int InputNum;

        public static void TakeInput()
        {
            Console.Write("Enter the value of N: ");
            InputNum = Convert.ToInt32(Console.ReadLine());
        }

        public static double Calculate()
        {
            double result = 0;
            for (double i = 1; i <= InputNum; i++)
            {
                result += 1 / i;
            }
            return Math.Round(result, 2);
        }

        public static void DisplayResult()
        {
            if (InputNum == 0)
                Console.WriteLine("Invalid Input");
            else
                Console.WriteLine("The Nth Harmonic Number is: " + Calculate());
        }
    }
}
