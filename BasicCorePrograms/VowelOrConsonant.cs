using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelOrConsonant
    {

        static char Letter;

        public static void TakeInput()
        {
            Console.Write("Enter an Alphabet: ");
            Letter = Convert.ToChar(Console.ReadLine().ToLower());
        }

        public static string Check()
        {
            if (Letter < 'a' || Letter > 'z')
                return "Invalid";
            else
            {
                switch (Letter)
                {
                    case 'a':
                        return "Vowel";
                    case 'e':
                        return "Vowel";
                    case 'i':
                        return "Vowel";
                    case 'o':
                        return "Vowel";
                    case 'u':
                        return "Vowel";
                    default:
                        return "Consonant";
                }
            }
            
        }

        public static void DisplayResult()
        {
            Console.WriteLine("The Entered Alphabet is " + Check());
        }
    }
}
