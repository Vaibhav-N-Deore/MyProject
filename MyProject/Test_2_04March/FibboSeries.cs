using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_2_04March
{
    internal class FibboSeries //Q.4
    {
        static void Main(string[] args)
        {
            int Fterm = 0, Sterm = 1;
            for(int i = 1; i<=20; i++)
            {
                Console.WriteLine(Fterm + " ");
                int Nterm = Fterm + Sterm;
                Fterm = Sterm;
                Sterm = Nterm;
            }
            Console.WriteLine();
        }
    }
}
