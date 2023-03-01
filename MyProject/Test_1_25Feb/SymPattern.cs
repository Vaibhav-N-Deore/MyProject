using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_Loop_25Feb
{
    internal class Sym_Pattern //Q.7
    {
        static void Main(string[] args)
        {
            int i, j;
            int n = 6;
            
            for(i=n;i>=1;i--)
            {
                for(j=n;j>=1;j--)
                {
                    if(i>j)
                        Console.Write("* ");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
