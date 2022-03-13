using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOf2
    {

        static int Power;

        public static void TakeInput()
        {
            Console.Write("Enter the exponent for 2: ");
            Power = Convert.ToInt32(Console.ReadLine());
        }

        public static int Calculate()
        {
            int result = 1;
            for (int i = 1; i <= Power; i++)
            {
                result *= 2;
            }
            return result;
        }

        public static void DisplayResult()
        {
            Console.WriteLine("The reqd result is: " + Calculate());
        }
    }
}
