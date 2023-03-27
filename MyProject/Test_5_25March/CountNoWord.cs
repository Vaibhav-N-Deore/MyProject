using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_5_25March
{
    internal class CountNoWord  //Q. WAP to count the number of words in a string
    {
        public static void Main()
        {
            int a = 0, myWord = 1;
            string str = "Hello World!";
            while (a <= str.Length - 1)
            {
                if (str[a] == ' ' || str[a] == ' ' || str[a] == '\t')
                {
                    myWord++;

                }
                a++;
            }
            Console.Write("Number of words in the string = {0}", myWord);
        }  
    }

}



