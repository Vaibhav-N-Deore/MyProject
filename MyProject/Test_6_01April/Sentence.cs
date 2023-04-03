using MyProject.Loop;
using MyProject.Oops;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyProject.Test_6_01April
{
    internal class Sentence  /* Q.Accept a sentence from user and write a logic to do sum of numbers
                              e.g) str=”my name25 is4 Rishi450”  output: 479*/
                              
    { 
        static int findSum(String str)
    {
          
            String temp = "0";

            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (char.IsDigit(ch))
                    temp += ch;

                else
                {
                   
                    sum += int.Parse(temp);

                    temp = "0";
                }
            }

            return sum + int.Parse(temp);
        }

        public static void Main(String[] args)
        {

            String str = "my name25 is4 Rishi450";

            Console.WriteLine(findSum(str));
        }
    }

}

