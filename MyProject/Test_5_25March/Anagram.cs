using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_5_25March
{
    internal class Anagram  //Q.WAP to check whether two strings are anagram or not?
    {
        static void Main(string[]args)
        {
            string str = Console.ReadLine();
            string str1 = Console.ReadLine();

            string s1 = str.ToLower();
            string s2 = str.ToLower();

            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string newstrings1 = new string(ch1);
            string newstrings2 = new string(ch2);

            if (newstrings1.CompareTo(newstrings2)==0)
            {
                Console.WriteLine("Both are Anagram");
            }
            else
            {
                Console.WriteLine("Both are not Anagram");
            }
        }
    }  
}
