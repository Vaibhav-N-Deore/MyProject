using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Pattern
{
    internal class ChaPattern1 // 23feb Q.4
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'A'; j <= 'D'; j++)
                {
                    if (i == 'A' || j == 'A' || i == 'D' || j == 'D')
                    {
                        Console.Write(j);
                    }
                   
                }
                       Console.WriteLine(" ");
            }
        }
    }

    internal class ChaPattern2 // 23feb Q.1
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write("i");
                }
                Console.WriteLine(" ");
            }
        }
    }
    internal class ChaPattern3 // 23feb Q.2
    {
        static void Main(string[] args)
        {

            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                {
                    Console.WriteLine();
                }
            }
        }
    }

    internal class ChaPattern4 // 23feb Q.2
    {
        static void Main(string[] args)
        {
   
            for(char i='A'; i<='D'; i++)
                {
            for(char j='A'; j<=i; j++)
                {
                    Console.Write("j");
                }
                Console.WriteLine();
                }

        }

    }
}
