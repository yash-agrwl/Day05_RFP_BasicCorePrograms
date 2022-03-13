using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        static int TotalFlip, TotalHead;
        public static void TakeInput()
        {
            Console.Write("Enter how many times to Flip: ");
            string num = Console.ReadLine();
            TotalFlip = Convert.ToInt32(num);
        }

        public static void Check()
        {
            Random random = new Random();
            int headNum = 0, flipNum = TotalFlip;
            while (flipNum > 0)
            {
                int coinFlip = random.Next(0, 2);
                if (coinFlip == 0)
                    headNum++;
                flipNum--;
            }
            TotalHead = headNum;
        }

        public static void DisplayResult()
        {
            int totalTail = TotalFlip - TotalHead;
            Console.WriteLine("Total number of Heads is: " + TotalHead + " and Tails is: " + totalTail);
            float headPercent = ((float)TotalHead / TotalFlip) * 100;
            float tailPercent = ((float)totalTail / TotalFlip) * 100;
            Console.WriteLine("Thus, the reqd percentage of Heads is: " + Math.Round(headPercent, 2)
                                            + "% and Tails is: " + Math.Round(tailPercent, 2) + "%");
        }
    }
}
