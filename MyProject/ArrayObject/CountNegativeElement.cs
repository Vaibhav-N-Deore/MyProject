using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayObject
{
    class CountNegativeElement
    {
        static void Main(string[] args)
        {

            int[] arr = new int[100];
            int i, num, negative = 0;

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
                //Print negative elements
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                    negative++;
                }

            }
            Console.WriteLine("Negative count is " + negative);
            Console.ReadLine();
        }
    }
}
