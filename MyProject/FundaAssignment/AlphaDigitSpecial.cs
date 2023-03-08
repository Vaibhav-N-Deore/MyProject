using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.FundaAssignment
{
    internal class AlphaDigitSpecial //Q.7.WAP to input any character and check whether it is alphabet, digit or special character 
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());


            if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine(ch + "is a Alphabet ");
            }


            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "is a Digit ");
            }


            else
            {
                Console.WriteLine(ch + "is a Special character ");
            }

        }
    }
}
