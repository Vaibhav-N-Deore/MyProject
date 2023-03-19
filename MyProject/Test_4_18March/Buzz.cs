using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_4_18March
{
    class Buzz
    {
        public static void Main()
        {
            int n = 50;

            // Loop for 50 times
            for (int i = 1; i <= n; i++)
            {
                // divisible by both 3 & 5),
                if (i % 15 == 0)
                    Console.Write("buzzfizz" + " ");

                else if (i % 3 == 0)
                    Console.Write("buzz" + " ");

               
                else if (i % 5 == 0)
                    Console.Write("fizz" + " ");

                // Print the numbers
                else
                    Console.Write(i + " ");
            }
        }
    }

}
