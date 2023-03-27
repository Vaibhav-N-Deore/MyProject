using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.stringclasswork
{
    internal class ReverseFirstLast
    {
        static String reverseWord(String str)
        {
            int len = str.Length;
            int i = 1;

            int j = str.Length - 2;

            char[] strchar = str.ToCharArray();

            while (i < j)
            {

                // Swap str[i] and str[j]
                char temp = strchar[i];
                strchar[i] = strchar[j];
                strchar[j] = temp;
                i++;
                j--;
            }
            str = new String(strchar);
            return str;
        }
        static void reverseWords(String str)
        {
            String[] tok = str.Split(' ');

            // While there are words left
            foreach (String w in tok)
            {

                // Print the reversed word
                Console.Write(reverseWord(w) + " ");
            }
        }
        public static void Main(String[] args)
        {
            String str = "Hello Think Quotient";
            reverseWords(str);
        }
    }

    
}

