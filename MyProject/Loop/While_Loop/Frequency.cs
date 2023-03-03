using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop.While_Loop
{
    internal class Frequency
    {
        static void Main(string[] args)
        {
            int count, temp, digit;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digit Number frequency is");
            count = 0;
            temp = num;
            for (int i = 0; i <= 9; i++)
            {

                while (temp > 0)
                {
                    digit = temp % 10;
                    if (digit == i)
                    {
                        count++;
                    }
                    temp = temp / 10;
                }
                if (count >= 0)
                {
                    Console.WriteLine("Frequency is " + i + "," + count);
                }
                Console.ReadLine();
            }
        }
    }
}
