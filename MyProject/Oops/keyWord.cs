using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Oops
{
    internal class Use1
    {
        int num;
        public void Inpute(int num)
        {
            this.num = num;
        }
        public void Display()
        {
            Console.WriteLine(num);
        }
    }
   /* class KeyWord
    {
        static void Main(string[] args)
        {
            Use1 u1 = new Use1();
            u1.Input(245);
            u1.Display();
        }

    }*/
}
