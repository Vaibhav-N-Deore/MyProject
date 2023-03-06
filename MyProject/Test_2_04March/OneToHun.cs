using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_2_04March
{
    internal class OneToHun //Q.1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 || i % 10 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadLine();
        }
        
    }
}
