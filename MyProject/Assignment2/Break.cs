using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment2
{
    internal class Break //Q.3
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; ++i)
            {

               //loop
                if (i == 3)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            Console.ReadLine();

        }
    }
}
