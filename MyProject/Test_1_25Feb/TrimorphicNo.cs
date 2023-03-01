using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_Loop_25Feb
{
    internal class Trimo_No //Q.5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no.");
            int number = Convert.ToInt32(Console.ReadLine());
            int cube = number * number * number;
            int flag = 0;

            while (number > 0)
            {
                if (number %10!= cube%10 )
                {
                    flag=1;
                    break;
                }
                number = number / 10;
                cube = cube / 10;
            }
            if (flag == 0)
            {
                Console.WriteLine("Trimorphic No.");
            }
            else
            {
                Console.WriteLine("Not Trimorphic No.");
            }
        }

    }
}
