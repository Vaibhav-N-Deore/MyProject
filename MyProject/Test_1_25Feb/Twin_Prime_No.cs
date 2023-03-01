using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_Loop_25Feb
{
    internal class TwinPrimeNo //Q.10
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Enter 1st no.");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd no.");
            int no2 = Convert.ToInt32(Console.ReadLine());

            for(int i=2; i<=no1/2 && i<=no2/2; i++)
            {
                if(no1%i==0 & no2%i==0)
                {
                    count = 1;
                    break;
                }
            }
            if (count==0 && (no1-no2==2 || no2-no1==2))
            {
                Console.WriteLine("Number is twin prime");
            }
            else
            {
                Console.WriteLine("Number is not twin prime");
            }
            Console.ReadLine();

        }
    }
}
