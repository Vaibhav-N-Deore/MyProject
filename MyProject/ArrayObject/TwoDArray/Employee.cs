using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayObject.TwoDArray
{
    // C# program to display the array of structure
    using System;
    using System.Xml.Linq;

    public class Employee
    {

        // Declare three variables
        // id, name and age
        private int id;
        private string name;
        private int age;
        private Employee[] employees;
        private int numEmployees;
        int delId;
        int i = 0;
        int pos = -1;
        int item = 0;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public Employee[] Employees { get => employees; set => employees = value; }
        public int NumEmployees { get => numEmployees; set => numEmployees = value; }

        // Set the employee details
        public void SetEmployee(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        // Display employee details
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee:");
            Console.WriteLine("\tId : " + Id);
            Console.WriteLine("\tName : " + Name);
            Console.WriteLine("\tAge : " + Age);
            Console.WriteLine("\n");
        }
        public void UpdateEmployee(int id, string name, int age)
        {
            for (int i = 0; i < numEmployees; i++)
            {
                if (employees[i].Id == id)
                {
                    employees[i].Name = name;
                    employees[i].Age = age;
                    return;
                }
            }
        }
        public void DeleteEmployee()
        {
            int index = -1;
           
                for (int i = 0; i < numEmployees; i++)
                {
                    if (employees[id].Id == delId)
                    {
                        pos = i;
                        break;
                    }


                }
           
            Console.WriteLine("Employee after deletion : ");
            for (i = 0; i < numEmployees; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + employees[i]);

            }
        }
    }
    class GFG
    {

        // Driver code
        static void Main(string[] args)
        {

            // Create array of structure
            Employee[] emp = { new Employee(),
                    new Employee(),
                    new Employee() };

            // Pass the array indexes with values as structures
            emp[0].SetEmployee(1, "Ojaswi", 20);
            emp[1].SetEmployee(2, "Rohit", 21);
            emp[2].SetEmployee(3, "Mohit", 23);

            // Call the display method
            emp[0].DisplayEmployee();
            emp[1].DisplayEmployee();
            emp[2].DisplayEmployee();

            //Update

            emp[0].UpdateEmployee(1, "Alice Smith", 11);
            Console.WriteLine("Enter id for Delete Employee Detail");
            int delId = Convert.ToInt32(Console.ReadLine());
            emp[delId].DeleteEmployee();
            //emp[0].DeleteEmployee();
        }
    }
}





