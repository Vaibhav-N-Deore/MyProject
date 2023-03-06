using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Inheritan.MultiLevel_Inhe
{
    class Employee
    {
        public string ename;
        public int eid=12;
        public string empDesignation="Software Engineer";
        public string empMailId="abc@gmail.com";
        public string empManagerName="XYZ";
        public string empMobileNo="2345676543";
       /* public Employee()
        {
            Console.WriteLine("Employee Name");

        }*/
       

    }
    class EmpInfo : Employee
    {
        public void Display()
        {
            Console.WriteLine("Employee Name  "+ename);
            Console.WriteLine("Employee Id  " +eid);
            Console.WriteLine("Employee Designation  " +empDesignation);
            Console.WriteLine("Employee EmailId  " + empMailId);
            Console.WriteLine("Employee Manager Name  " + empManagerName);
            Console.WriteLine("Employee Mobile Number " + empMobileNo);
        }
        static void Main(string[] args)
        {
            EmpInfo emp = new EmpInfo();
            Console.WriteLine("Employee Name");
            string ename = Console.ReadLine();

            emp.Display();
        }

    }



}
