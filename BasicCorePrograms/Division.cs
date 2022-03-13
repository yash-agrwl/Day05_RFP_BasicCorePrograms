using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Division
    {

        static int Divisor, Dividend;

        public static void TakeInput()
        {
            Console.Write("Enter the value of Divisor: ");
            Divisor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of Dividend: ");
            Dividend = Convert.ToInt32(Console.ReadLine());
        }

        public static int GetQuotient()
        {
            return Dividend / Divisor;
        }

        public static int GetRemainder()
        {
            return Dividend % Divisor;
        }

        public static void DisplayResult()
        {
            Console.WriteLine("The Reqd value of Quotient is: " + GetQuotient() + " and Remainder is: " + GetRemainder());
        }
    }
}
