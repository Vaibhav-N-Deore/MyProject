using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class Class1  //wrie code to check odd or even
    {
        static void Main(string[] args)
        {
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

    internal class class2  //write code to check num +ve or -ve
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine("Positive Number");
            }

            else
                Console.WriteLine("Negative Number");

        }
    }

    internal class class3  //write code to check num is multiple 3 or not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());

            if (n % 3 == 0)
            {
                Console.WriteLine("Buzz number");
            }
            else
                Console.WriteLine("Not buzz number");

        }
    }

    internal class class4 //write code to check num is +ve -ve or zero
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter any number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine("Positive Number ");
            }

            else if (n < 0)
            {
                Console.WriteLine("Nagative Number ");
            }

            else
            {
                Console.WriteLine("Eumber is zero ");
            }

        }

    }

    internal class class5 //write code to check num is divisible by 3 or 9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());

            if (n % 3 == 0 && n % 9 == 0)
            {
                Console.WriteLine("Divisible by 3 and 9");
            }
            else
                Console.WriteLine("Not divisible by 3 and 9");
        }

    }

    internal class class6 //write code to check character is alphabets or digit
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());



            if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine(ch + "It's a Alphabet. ");
            }

            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "It's a Digit");
            }

            else
            {
                Console.WriteLine(ch + "It's a Special character");
            }

        }
    }

    internal class class7 //write code to check num is greater than 15 and less than 100 or not 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());

            if (n > 15 && n < 100)
            {

                Console.WriteLine("Number is greater than 15");
            }

            else if (n < 100)
            {
                Console.WriteLine("Number is less than 100");
            }
            else
            {
                Console.WriteLine("not");
            }
        }
    }


}

