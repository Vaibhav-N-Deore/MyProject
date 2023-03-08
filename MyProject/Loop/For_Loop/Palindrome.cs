using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop.For_loop
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            int num, rev, n, r, sum = 0;

            Console.Write("Input a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (rev = n; n != 0; n = n / 10)
            {
                r = n % 10;
                sum = sum * 10 + r;
            }
            if (rev == sum)
                Console.Write("{0} is a palindrome number.\n", rev);
            else
                Console.Write("{0} is not a palindrome number.\n", rev);

            //palindrome number between 100 to 500
            Console.WriteLine("Palindrome  No between 100 to 500 is ");
            for (num = 100; num <= 500; num++)
            {
                rev = 0;
                n = num;
                while (n != 0)
                {
                    r = n % 10;
                    rev = rev * 10 + r;
                    n = n / 10;
                }
                if (num == rev)
                    Console.Write(num + ",");
            }
            Console.Read();
        }
    }
}

