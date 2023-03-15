using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_3_11March
{
    public class Person
    {
        protected string Tel = "123-45-6666";
        protected string name = "Vaibhav Deore";

        public virtual void GetInfo()
        {
           Console.WriteLine("Tel: {0}", Tel);
           Console.WriteLine("Name: {0}", name);
        }
    }
    class Employee : Person
    {
        public string id = "VND159357";
        public override void GetInfo()
        {
            // Calling the base class GetInfo method:
            base.GetInfo();
            Console.WriteLine("Employee ID: {0}", id);
        }
    }

    class TestClass
    {
        static void Main()
        {
            Employee E = new Employee();
            E.GetInfo();
        }
    }
    
}
