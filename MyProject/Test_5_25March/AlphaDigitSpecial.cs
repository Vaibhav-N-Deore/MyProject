using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_5_25March
{
    internal class AlphaDigitSpecial //Q.WAP to find total number of alphabets, digits or special character in a string.
    {
        static void Main(string[] args)
        {
            int alphabets, digit, sp_symbols;
            string str;
            int i = 0;
            alphabets = digit = sp_symbols = 0;

            Console.WriteLine("Entering string");
            str = Console.ReadLine();

            while (i < str.Length)
            {
                if ((str[i] >= 'A' && str[i]<='Z') || (str[i] >= 'a' && str[i] <= 'z'))
                {
                    alphabets++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    sp_symbols++;
                }
                i++;
            }
            Console.WriteLine("Number of Alphabets={0}",alphabets);
            Console.WriteLine("Number of Digit={0}",digit);
            Console.WriteLine("Number of sp_symbol={0}", sp_symbols);
        }
    }
}
