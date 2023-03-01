using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_Loop_25Feb
{
    internal class No_One_ToHun //Q.1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
               if(i%5==0 || i % 10 == 0)
                {
                    Console.WriteLine(i);
                }
               
            }
            Console.ReadLine();
        }
    }
}
