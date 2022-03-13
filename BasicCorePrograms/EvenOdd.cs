using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenOdd
    {

        static int Num;

        public static void TakeInput()
        {
            Console.Write("Enter the Number to check: ");
            Num = Convert.ToInt32(Console.ReadLine());
        }

        public static string Check()
        {
            if (Num % 2 == 0)
                return "Even";
            else
                return "Odd";
        }

        public static void DisplayResult()
        {
            Console.WriteLine("The Entered Number is " + Check());
        }
    }
}
