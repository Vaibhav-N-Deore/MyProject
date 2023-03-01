using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_1_25Feb
{
    internal class Series //Q.11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It Will Print Series");
            int a;
            for(int i=1;i<=10;i++)
            {
                a = i * i + i * i * i;
                Console.Write(a+",");

            }
            Console.ReadLine();
        }
    }
}
