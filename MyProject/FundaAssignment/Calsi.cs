using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.FundaAssignment
{
    internal class Calsi //Q.5.WAP to create Simple Calculator  
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operation;
            float answer;

            Console.Write("Enter first digit:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("operation to perform (+, -, /, *): ");
            operation = Console.ReadLine();

            Console.Write("Enter second digit: \n");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {

                case "-":
                    answer = num1 - num2;
                    break;

                case "+":
                    answer = num1 + num2;
                    break;

                case "/":
                    answer = num1 / num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                default:
                    answer = 0;
                    break;
            }
            Console.WriteLine(num1.ToString() + " " + operation + " " + num2.ToString() + " = " + answer.ToString());
        }
    }
}
