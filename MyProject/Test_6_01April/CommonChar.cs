using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_6_01April
{
    internal class CommonChar

       /*Q. Write a  program or function which takes two strings as
        input and print common characters between them in alphabetical order.
        For example, if "thin sticks" and "thick bricks" are two given input 
        strings then common characters between them in alphabetical order are    
         [c, h, i, k, s, t]. */

    {
        static void Main(string[] args)
        {
            string str1 = "thin sticks";
            string str2 = "thick bricks";

            var commonChars = str1.Intersect(str2).OrderBy(c => c);

            Console.WriteLine("Common characters between two strings:");
            foreach (var ch in commonChars)
                Console.Write(ch + " ");
        }
    }
}
