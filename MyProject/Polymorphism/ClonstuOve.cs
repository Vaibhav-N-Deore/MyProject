using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Polymorphism
{
    internal class ClonstuOve
    {
        class Car
        {

            // constructor with string parameter
            Car(string brand)
            {
                Console.WriteLine("Brand: " + brand);
            }

            // constructor  with int parameter
            Car(int price)
            {
                Console.WriteLine("Price: " + price);
            }

            static void Main(string[] args)
            {

                // call constructor  with string parameter
                Car car = new Car("Suzuki");

                Console.WriteLine();

                // call constructor  with int parameter
                Car car2 = new Car(50000);

                Console.ReadLine();
            }
        }
    }
}

