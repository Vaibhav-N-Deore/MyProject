using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment2
{
    internal class OdNo
    {
        static void Main(string[] args)
        {
            int number;
            int n;
            number = 1;
            Console.WriteLine("Odd Numbers from 521 to 229 :");

            while (number <= 521)
            {
                if (number % 2 != 0)
                    Console.Write("%d ", number);

                number++;

            }

        }
    }
}
