using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentOnStatic
{
    //We can not inherite Static Parent method in child class
    //it gives error member of parent method can not be accessed
    //with an instance reference
    class Parent1
        {
            public static void study()
            {
                Console.WriteLine("By reading book");
            }

        }
        class child : Parent1
        {
            public void study()
            {
                Console.WriteLine("By watching  videos");
            }
        }
        class childd
        {
            static void Main(string[] args)
            {
                Parent1 pp = new Parent1();
              //  pp.study();
                Parent1 pp1 = new child();
              //  pp1.study();
                Console.ReadLine();
            }


        }
    }

