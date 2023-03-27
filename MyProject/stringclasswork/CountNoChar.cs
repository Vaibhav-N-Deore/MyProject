using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.stringclasswork
{
    internal class CountString
    {
        public static int count = 0;
        public static void ReverseText(string text)
        {
           
            for(int i=0;i<text.Length;i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String: ");
            string str=Console.ReadLine();
            CountString.ReverseText(str);
        }
    }

   internal class NumberOfWords
    {
        static int count = 0;
        public static void CountWords(string str) 
        {
            string[] arr = str.Split();
            for(int i=0;i<arr.Length;i++)
            {
                count++;
            }
            Console.WriteLine("Number of words in sentence is: "+count);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence: ");
            string str = Console.ReadLine();
            NumberOfWords.CountWords(str);

        }
    }
}
