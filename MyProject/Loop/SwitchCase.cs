using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class SwitchCase // write code to disply 1 to 5 no. in word using switch case
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

    internal class SwitchCase1 // write code to check even charactor is vowel and consonent using switch case 
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any alphabet: ");
            ch = Convert.ToChar(Console.ReadLine());


            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Vowel ");
                    break;

                case 'e':
                    Console.WriteLine("Vowel ");
                    break;

                case 'i':
                    Console.WriteLine("Vowel ");
                    break;

                case 'o':
                    Console.WriteLine("Vowel ");
                    break;

                case 'u':
                    Console.WriteLine("Vowel ");
                    break;

                case 'A':
                    Console.WriteLine("Vowel ");
                    break;

                case 'E':
                    Console.WriteLine("Vowel ");
                    break;

                case 'I':
                    Console.WriteLine("Vowel ");
                    break;

                case 'O':
                    Console.WriteLine("Vowel ");
                    break;

                case 'U':
                    Console.WriteLine("Vowel ");
                    break;

                default:
                    Console.WriteLine("consonant ");
                    break;
            }
        }

    }

    internal class SwitchCase2 //write code to check even input is odd or even using switch case 
    {
        static void Main(string[] args)
        {

            int num;

            Console.Write("Enter any number : ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num % 2)
            {
                //If n%2 == 0
                case 0:
                    Console.WriteLine(num + " is even number");
                    break;

                //Else if n%2 == 1
                case 1:
                    Console.WriteLine(num + " is odd number");
                    break;
            }

        }
    }

    internal class SwitchCase3 //write code to calculate the area of circle, Rectangle, Tringle, Square as per the user choice using switch case
    {
        static void Main(string[] args)
        {
           
            }
        }

}




       

