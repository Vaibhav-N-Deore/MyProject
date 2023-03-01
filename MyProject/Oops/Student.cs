using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Oops
{
    internal class Student
    {
        int id;
        string name;
        int m1, m2, m3;
        int per;

        public void Accept(int sid, string sname, int mk1, int mk2, int mk3)
        {
            id = sid;
            name = sname;
            m1 = mk1;
            m2 = mk2;
            m3 = mk3;

        }
        public void calculatepercentage()
        {
            per = ((m1 + m2 + m3) * 100) / 300;
        }
        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + m1 + " " + m2 + " " + m3);
        }
        static void main(string[] args)
        {
            Student s = new Student();
            s.Accept(1, "vaibhav", 50, 60, 70);
            s.calculatepercentage();
            s.Display();
        }
    }
}
