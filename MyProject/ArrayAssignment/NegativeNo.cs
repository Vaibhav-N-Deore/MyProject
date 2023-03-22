using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayAssignment
{
    internal class NegativeNo  //Q.	WAP to print all negative elements in an array and also count total number of negative elements in an array.
    {
        static void Main()
        {
            int[] arr = new int[100];
            int i, num;

            
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter elements in array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("All negative elements in array are: ");
            for (i = 0; i < num; i++)
            {
              
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
