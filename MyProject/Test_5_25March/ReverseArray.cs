using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_5_25March
{
    internal class ReverseArray //Q.WAP to reverse the array itself, don’t print array in reverse –
                                //I want current array reverse. Means
                                //e.g. arr[] = [3, 90, 45, 29, 37, 78] so your same array must be
                                //[78, 37, 29, 45, 90, 3] without using temporary array
    {
        static void Main(string[] args)
        {

            int[] a = new int[100];
            Console.Write("  Enter size of array :");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("  Enter number of elements in the array :", size);
            for (int i = 0; i < size; i++)
            {
                Console.Write(i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Value in Array is ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine("After reversing the array value is ");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i] + " ");
            }
            Console.ReadLine();
        }
    }
}

