using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Oops
{
    class Car

    {
        int model;
        string name;
        int price;
        public Car(int id, string cname, int cost)
        {
            model = id;
            name = cname;
            price = cost;
        }
        void Display()
        {
            Console.WriteLine(model + " " + name + " " + price);
        }
        static void Main(string[] args)
        {
            Car c = new Car(1223, "Audi", 890000);
            c.Display();
        }
    }

} 
