using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop.Pattern_Program.Character_Pattern
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            /* A
               BB
               CCC
               DDDD
               EEEEE*/

            for (char r = 'A'; r <= 'E'; r++)
            {
                for (char c = 'A'; c <= r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }
    }

    class Class2
    {
        static void Main(string[] args)
        {
            /*A
               AB
               ABC
               ABCD
               ABCDE*/
            for (char r = 'A'; r <= 'E'; r++)
            {
                for (char c = 'A'; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }
    }
    class Class3
    {
        static void Main(string[] args)
        {
          /*A
            BB
            CCC
            DDDD
            EEEEE*/

            for (char r = 'A'; r <= 'E'; r++)
            {
                for (char c = 'A'; c <= r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();

        }
    }
    class Class4
    {
        static void Main(string[] args)
        {

        }
    }
}
