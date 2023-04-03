using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayObject.TwoDArray
{
    public class School
    {
        public Student[] students;
        private int numStudents;

        public School()
        {
            students = new Student[100];
            numStudents = 0;
        }

        public void AddStudent(Student s)
        {
            if (numStudents >= students.Length)
            {
                Console.WriteLine("Error: maximum number of students reached");
                return;
            }

            students[numStudents] = s;
            numStudents++;
        }

        public void RemoveStudent(int id)
        {
            for (int i = 0; i < numStudents; i++)
            {
                if (students[i].Id == id)
                {
                    for (int j = i; j < numStudents - 1; j++)
                    {
                        students[j] = students[j + 1];
                    }
                    students[numStudents - 1] = null;
                    numStudents--;
                    return;
                }
            }

            Console.WriteLine("Error: student with ID " + id + " not found");
        }

        public void EditStudent(int id, string name, int @class, double result)
        {
            for (int i = 0; i < numStudents; i++)
            {
                if (students[i].Id == id)
                {
                    students[i].Name = name;
                    students[i].Class = @class;
                    students[i].Result = result;
                    return;
                }
            }

            Console.WriteLine("Error: student with ID " + id + " not found");
        }

        public void DeleteStudent(int id)
        {
            int index = -1;

            for (int i = 0; i < numStudents; i++)
            {
                if (students[i].Id == id)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Error: student with ID " + id + " not found");
                return;
            }

            for (int i = index; i < numStudents - 1; i++)
            {
                students[i] = students[i + 1];
            }

            students[numStudents - 1] = null;
            numStudents--;
        }

       public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Class { get; set; }
            public double Result { get; set; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            school.AddStudent(new School.Student { Id = 1, Name = "Alice", Class = 10, Result = 95.0 });
            school.AddStudent(new School.Student { Id = 2, Name = "Bob", Class = 9, Result = 85.0 });
            school.AddStudent(new School.Student { Id = 3, Name = "Charlie", Class = 10, Result = 90.0 });

            school.DeleteStudent(2);

            school.EditStudent(1, "Alice Smith", 11, 98.0);

            foreach (School.Student s in school.students)
            {
                if (s != null)
                {
                    Console.WriteLine("ID: " + s.Id);
                    Console.WriteLine("Name: " + s.Name);
                    Console.WriteLine("Class: " + s.Class);
                    Console.WriteLine("Result: " + s.Result);
                    Console.WriteLine();
                }
            }
        }
    }

} 


