using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {

        static int YearInput;

        public static void TakeInput()
        {
            Console.Write("Enter Year: ");
            string input = Console.ReadLine();
            if (input.Length == 4)
                YearInput = int.Parse(input);
            else
                YearInput = -1;
        }

        public static bool IsLeapYear()
        {
            if (YearInput % 400 == 0 || (YearInput % 100 != 0 && YearInput % 4 == 0))
                return true;
            else
                return false;
        }

        public static void DisplayResult()
        {
            if (YearInput == -1)
                Console.WriteLine("The given Input is Invalid");
            else if (IsLeapYear())
                Console.WriteLine(YearInput + " is a Leap Year.");
            else
                Console.WriteLine(YearInput + " is not a Leap Year");
        }
    }
}
