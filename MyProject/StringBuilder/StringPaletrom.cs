using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.StringBuilder
{
    class PalindromeStri
    {
        /* static void Main(string[] args)
         {
             string s, rev = "";
             Console.WriteLine(" Enter string");
             s = Console.ReadLine();
             for (int i = s.Length - 1; i >= 0; i--)
             {
                 rev = rev + s[i];
             }
             if (rev == s)
             {
                 Console.WriteLine("Palindrome");
             }
             else
             {
                 Console.WriteLine("Not Palindrome");
             }
             Console.ReadLine();
         }
 */


        static void Main(string[] args)
        {
            String input = "vabs";
            StringBuilder stb = new StringBuilder(input);

            String output = stb.reverse().toString();
            Console.WriteLine("output: " + output);

            if (input.equals(output))
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }
        }
    }
}