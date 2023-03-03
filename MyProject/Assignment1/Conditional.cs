using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment
{
    internal class Conditional1 //Write a program to check whether a year is leap year or not 
    {
        static void Main(string[] args)
        {
            int ch;

            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());

            if
            (Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0)

                Console.WriteLine("{0} is a Leap Year.", Year);

            else
                Console.WriteLine("{0} is not a Leap Year.", Year);
            Console.ReadLine();

        }
    }

    internal class conditional2 //Write a  program to check whether a number is divisible by 5 and 11 or not 
    {
        static void Main(string[] args)
        {
            int num;
            num = 55;

            Console.WriteLine("Number: " + num);

            // if the number is divisible by 5 and 11

            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("Divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("Not divisible by 5 and 11");
            }
        }
    }

    internal class conditional3 // Write a program to find maximum between three numbers 
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            num1 = 10;
            num2 = 20;
            num3 = 50;

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!");
                }

                else
                {
                    Console.Write("Number three is the largest!");
                }

            }
            else if (num2 > num3)

                Console.Write("Number two is the largest!");

            else
                Console.Write("Number three is the largest!");
        }
    }

    internal class conditional4 //Write a program to input any alphabet and check whether
                                //it is vowel or consonant 
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            if
                (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is Vowel.");
            }

            else if
                (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine(ch + " is Consonant.");
            }

        }
    }

    internal class conditional5 // Write a program to create Simple Calculator
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

    internal class conditional6 // Write a program to check whether a number is negative, positive or zero 
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Number is positive ");
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is nagative ");
            }
            else
            {
                Console.WriteLine("Number is zero ");
            }

        }
    }

    internal class conditional7 // Write a program to input any character and check whether it is alphabet,
                                // digit or special character 
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());


            if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine(ch + "is a Alphabet ");
            }


            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "is a Digit ");
            }


            else
            {
                Console.WriteLine(ch + "is a Special character ");
            }

        }
    }

    internal class conditional8 //Write a program to check whether a number is even or odd  
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Even Number" + n);
            }
            else
                Console.WriteLine("Odd Number" + n);
        }
    }

    internal class conditional9 // TQ Assignment Que.9,10,11 
    {
        static void Main(string[] args)
        {

        }
    }

    //switch case code

    internal class switch1 // Write a program to create Simple Calculator using switch case Menu Driven 

    {
        int ch;
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("----------------------------");

            Console.WriteLine("press\n 1.Add\n 2.Substract\n 3.Multiply\n 4.Divide");
            Console.WriteLine("----------------------------");

            Console.Write("Enter Choice(1-4):");
            int ch = int.Parse(Console.ReadLine());

            int a, b, c;
            switch (ch)
            {
                case 1:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Sum = {0}", c);
                    break;

                case 2:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Difference = {0}", c);
                    break;

                case 3:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Product = {0}", c);
                    break;

                case 4:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Quotient = {0}", c);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
    internal class switch2 // Write a program that displays the day of the week corresponding to
                           // the number entered-1 - "Monday", 2- "Tuesday" and so on.
    {
        static void Main(string[] args)
        {
            int life;

            Console.Write("The day of the week corresponding to the number :\n");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input Day No : ");
            life = Convert.ToInt32(Console.ReadLine());

            switch (life)
            {
                case 1:
                    Console.Write("Monday \n");
                    break;

                case 2:
                    Console.Write("Tuesday \n");
                    break;

                case 3:
                    Console.Write("Wednesday \n");
                    break;

                case 4:
                    Console.Write("Thursday \n");
                    break;

                case 5:
                    Console.Write("Friday \n");
                    break;

                case 6:
                    Console.Write("Saturday \n");
                    break;

                case 7:
                    Console.Write("Sunday  \n");
                    break;

                default:
                    Console.Write("Invalid day number\n");
                    break;
            }
        }
    }

    internal class switch3 //Write a program to enter number between 1 to 5 and print it in word

    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter 1 to 5:");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Console.WriteLine("One ");
                    break;

                case "2":
                    Console.WriteLine("Two ");
                    break;

                case "3":
                    Console.WriteLine("Three ");
                    break;

                case "4":
                    Console.WriteLine("Four ");
                    break;

                case "5":
                    Console.WriteLine("Five ");
                    break;

                default:
                    Console.WriteLine("not a digit");
                    break;
            }
        }
    }

}
