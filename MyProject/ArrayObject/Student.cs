/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayObject
{
    internal class Student
    {
        internal int id;
        internal string name;
        internal double per;
        public Student(int id, string name, int per)
        {
            this.id = id;
            this.name = name;
            this.per = per;

          
        }
        public override string ToString()
        {
            return id + " " + name + " " + per;
        }
    }
    class ArrayObjectDemo
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "vaibhav", "85.70");
            Console.WriteLine(s);

            Student[] stud= new Student[3];
            stud[0] = new Student(1, "vaibhav", 70.00);
            stud[1] = new Student(1, "akash", 60.30);
            stud[2] = new Student(1, "abhi", 50.86);

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter the id");
                int eid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the sname");
                string sname =Console.ReadLine();
                Console.WriteLine("Enter the per");
                int per = int.Parse(Console.ReadLine());

                stud[i] = new Student(eid, sname, per);
            }

            Console.WriteLine("-------------------");
            foreach(Student stu in stud)
             {
                if (stud.per > 60.00)
                {
                    Console.WriteLine(stud);
                }
               
             }
        }
    }

}

*/