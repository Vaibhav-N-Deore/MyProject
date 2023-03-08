using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.FundaAssignment
{
    internal class Fahrenheit //Q.4.Write a program to enter temperature in °Celsius and convert it into °Fahrenheit.
    {
        static void Main(string[] args)
        {

            double fahrenheit;

            double celsius = 36;
            Console.WriteLine("Celsius: " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            Console.ReadLine();
        }
    }
}
