using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_1_25Feb
{
    internal class EvenOddNegSqa //Q.12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It will print even no. as it is and square of odd no.");

            for(int i = 1; i <=50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ",");
                }
                else
                {
                    int num = i*i;
                    Console.Write(num + ",");
                }
            }
            Console.ReadLine();
        }
    }
}
