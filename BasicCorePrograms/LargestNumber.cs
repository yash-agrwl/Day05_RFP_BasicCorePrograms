using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestNumber
    {

        static int Num1, Num2, Num3;

        public static void TakeInput()
        {
            Console.Write("Enter First Number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            Num3 = Convert.ToInt32(Console.ReadLine());
        }

        public static int Find()
        {
            int big = Num1;
            if(big < Num2)
                big = Num2;
            if(big < Num3)
                big = Num3;
            return big;
        }

        public static void DisplayResult()
        {
            Console.WriteLine("The Largest Number is: " + Find());
        }
    }
}
