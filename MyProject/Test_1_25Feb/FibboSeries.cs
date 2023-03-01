using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_Loop_25Feb
{
    internal class Fibbo_Series //Q.13
    {
        static void Main(string[] args)
        {
            int fterm = 0, sterm = 1;

            for(int i=1; i <= 20; i++)
            {
                Console.WriteLine(fterm +" ");
                int Nterm = fterm + sterm;
                fterm = sterm;
                sterm = Nterm;
            }
            Console.WriteLine();
        }
    }
}
