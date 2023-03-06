using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_2_04March
{
    internal class EvenOddSquare //Q.3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print even no.as it is and odd no.square");
            for(int i = 1; i<= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+ ",");
                }
                else
                {
                    int num = i * i;
                    Console.Write(num + ",");
                }
            }
            Console.ReadLine();
        }
    }
}
