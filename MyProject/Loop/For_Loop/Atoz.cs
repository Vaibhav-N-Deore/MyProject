using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop.For_loop
{
    internal class Atoz
    {
        static void Main(string[] args)
        {
            char ch;
            for (ch = 'a'; ch <= 'z'; ch++)
            {
                Console.WriteLine(ch);
            }
            Console.Read();
        }
    }
}
