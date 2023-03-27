using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentOnStatic
{
    internal class StatMethod5
    {
            public static int i;
            public static void display()
            {
                int i = 10;
                Console.WriteLine(i);
            }
            public void demo()
            {
                int j = 20;
                Console.WriteLine(j);
            }
            static void Main(string[] args)
            {
                StatMethod5 sm = new StatMethod5();
                StatMethod5.display();
                sm.demo();
                Console.Read();
            }
        
    }
}
