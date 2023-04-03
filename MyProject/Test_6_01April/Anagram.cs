using MyProject.Test_5_25March;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_6_01April
{
    internal class Anagram
    {
        /*Q.WAP to check if two Strings are anagrams of each other?
        (Two strings are anagrams if they are written using the same exact
        letters, ignoring space, punctuation and capitalization.
        Each letter should have the same count in both strings.
        Eg), Army and Mary are anagram of each other.*/

        public static void Main()
        {
            string str1 = "Army";
            string str2 = "Mary";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Anagram");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagram");
            }
        }
    }
}
