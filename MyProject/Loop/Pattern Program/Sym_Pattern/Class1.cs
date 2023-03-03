using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop.Pattern_Program.Sym_Pattern
{
    internal class Class1
    {
        static void Main(string[] args)
        {
                    
                  /*    *
                       ***
                      *****
                     *******
                    *********
                   ***********
                  *************
                 ***************
                *****************   */
                                   

            Console.WriteLine("Enter Number Of Rows");
            int r1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= r1; i++)
            {
                for (int space = 1; space < r1 - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }


}
