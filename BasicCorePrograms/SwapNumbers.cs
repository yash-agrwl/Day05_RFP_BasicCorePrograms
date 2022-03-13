using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapNumbers
    {
        static int Num1, Num2;

        public static void TakeInput()
        {
            Console.Write("Enter First Number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
        }

        public static void Swap()
        {
            int temp;
            temp = Num1;
            Num1 = Num2;
            Num2 = temp;
        }
        
        public static void DisplayResult()
        {
            Swap();
            Console.WriteLine("The values after swapping are: First Number= " + Num1 + " & Second Number= " + Num2);
        }
    }
}
