using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_5_25March
{
    internal class Replace //Q.WAP to replace all the 0’s with 1’s in your array.
                           //Your array is [26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34].
    {
        // A iterative function to reverse a number
        static int reverseTheNumber(int temp)
        {
            int ans = 0;
            while (temp > 0)
            {
                int rem = temp % 10;
                ans = ans * 10 + rem;
                temp = temp / 10;
            }
            return ans;
        }

        static int convert0To1(int num)
        {
            // if num is 0 return 1
            if (num == 0)
                return 1;

            // Extract the last digit and
            // change it if needed
            else
            {
                int temp = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    //if digit is 0, make it 1
                    if (digit == 0)
                        digit = 1;

                    temp = temp * 10 + digit;
                    num = num / 10;
                }

                // call the function reverseTheNumber by passing
                // temp
                return reverseTheNumber(temp);
            }
        }

        // Driver Code
        public static void Main(string[] args)
        {
           // int num = 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 ;
          //  Console.Write(convert0To1(num));

        }
    }
}

