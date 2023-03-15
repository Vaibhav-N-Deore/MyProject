/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayObject
{
    internal class Employe
    {
        int id;
        String name;
        String deptname;
        float salary;
        static int numberofobjects = 0;
        Employe()
        {
            id = 0;
            name = "";
            deptname = "";
            salary = 0;
        }
        Employe(int id, String name, String deptname, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            numberofobjects++;
        }
        public void display()
        {
            Console.WriteLine("Employee Id :" + id);
            Console.WriteLine("Employee name: " + name);
            Console.WriteLine("Employee Salary :" + salary);
        }
        public static void main(String[] args)
        {
            int n = 0;
            Scanner sc = new Scanner(System.in);
            Console.WriteLine("How many employees you want to enter :");
            n = sc.nextInt();
            Employee[] ob = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                sc = new Scanner(System.in);
                System.out.println("Enter Id of employee " + (i + 1) + " :");
                int id = sc.nextInt();
                System.out.println("Enter Name of employee " + (i + 1) + " :");
                sc.nextLine();
                String name = sc.nextLine();
                System.out.println("Enter salary of employee " + (i + 1) + " :");
                float salary = sc.nextFloat();
                ob[i] = new Employee(id, name, deptname, salary);
                System.out.println("\nNumber of Objects : " + numberofobjects);

            }
            for (int i = 0; i < n; i++)
            {
                ob[i].display();
            }
        }
    }
}
*/