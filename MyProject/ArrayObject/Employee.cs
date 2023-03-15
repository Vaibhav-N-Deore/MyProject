/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayObject
{
    internal class Employee
    {
        internal int id;
        internal string name;
        internal int sal;
        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.sal = salary;

          
        }
        public override string ToString()
        {
            return id + " " + name + " " + sal;
        }
    }
    class ArrayObjectDemo
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(1, "vaibhav", 30000);
            Console.WriteLine(e);

            Employee[] e= new Employee[3];
            e[0] = new Employee(1, "vaibhav", 25000);
            e[1] = new Employee(1, "akash", 30000);
            e[2] = new Employee(1, "abhi", 35000);

            for (int i = 0; i < e.Length; i++)
            {
                Console.WriteLine("Enter the id");
                int eid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name");
                string ename =Console.ReadLine();
                Console.WriteLine("Enter the sal");
                int sal = int.Parse(Console.ReadLine());

                *//* emp[i] = new Employee(eid, ename, sal);*//*
                e[i] = new Employee(eid, ename, sal);
            }

            Console.WriteLine("-------------------");

            foreach(Employee sal in e)
             {
                if (e. > 25000)
                {
                    Console.WriteLine(e);
                }
               
             }
        }
    }

}
*/