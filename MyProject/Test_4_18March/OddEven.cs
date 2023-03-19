using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_4_18March
{
    class OddEven
    {
        static void Main(string[] args)
        {
            //count total number even,odd elements in an array

            int size, even, odd;
            int[] arr;

            Console.Write("Enter size of array: ");    //size of array
            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0} elements in array:", size);   //array element

            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Number({0}) :", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
                                                      //Assuming that there are 0 even and odd elements 
            even = 0;
            odd = 0;
            for (int i = 0; i < size; i++)
            {
                                                   //If current element array is even then 
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.Write("Total even elements: {0}\n", even);
            Console.Write("Total odd elements: {0}", odd);

            Console.ReadLine();
        }
    }

}
