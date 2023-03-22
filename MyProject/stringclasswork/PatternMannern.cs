using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.stringclasswork
{
    internal class PatternMannern
    {
        static void Main()
        {
            string str = "VAIBHAV";
            for(int i=0; i<=str.Length-1; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write(str[j]);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
