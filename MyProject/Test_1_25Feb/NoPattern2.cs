using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_Loop_25Feb
{
    internal class NoPattern2
    {
        static void Main(string[] args)
        {
            /*  12345
              1234
              123
              12
              1*/
            for (int j = 5; j >= 1; j--)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine(" ");

            }
        }
    }
  /* internal class NoPattern2
    {
       static void Main(string[] args)
        {
             12345
               2345
               345
               45
               5*/
            /*for (int j = 1; j <= 5; j++)
            {
                for (int i = j; i <= 5; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine(" ");

            }


       }
    }*/
}
