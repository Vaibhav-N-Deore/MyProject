/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.StructClassWork
{
    public struct Employee
    {
        int eId;
        int eAge;
        string eName;


        public Employee(int eid, string ename, int eage)
        {
            this.eId = eid;
           this. eName = ename;
           this. eAge = eage;
        }

        public void Display()
        {
            Console.WriteLine(eId+ " "+eName+" "+eAge);
        }


        class Demo
        {
            static void Main(string[] args)
            {
                Employee[] e = new Employee[5];
                for(int i = 0; i < e.Length; i++)
                {
                    Console.WriteLine("Enter id");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter age");
                    int age= int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter name");
                    string ename=Console.ReadLine();

                Employee e = new Employee(id, age, ename);
                e[i] = e;

                }

                foreach(Employee e in e)
                {
                    e.DisplayEmployee();
                }

            

            }
        }
  

   } 
}
*/