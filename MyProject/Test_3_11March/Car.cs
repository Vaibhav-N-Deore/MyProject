using MyProject.Oops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_3_11March
{
    internal class Car //parent class
    {
        public void Lexus()
        {
            Console.WriteLine("please Drive Lexus");
        }
    }
    class Driver : Car // Drive child class
    {
        public void Drive()
        {
            Console.WriteLine("Yes I will Drive");
        }
    }
    class Owner : Car //child 
    {
        public void OwnerCar()
        {
            Console.WriteLine("vaibhav");
        }
    }

    class Demo
    {
        static void Main(string[] args)
        {
            Owner Ow = new Owner();
            Driver dr = new Driver();
            dr.Drive();
            Ow.OwnerCar();
            Ow.Lexus();

            Console.ReadLine();
        }
    }

}
