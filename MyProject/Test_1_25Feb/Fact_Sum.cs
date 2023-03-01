using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_Loop_25Feb
{
    internal class Fact_Sum //Q.14
    {
        static void Main(string[] args)
        {
            int fact = 1, num;
            Console.WriteLine("Enter The No. To Check The Factorial Of No.");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial Of  " +num+ " Is " +fact);
        }
    }
}
