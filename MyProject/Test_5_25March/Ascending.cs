using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_5_25March
{
    internal class Ascending  //Q.WAP sort array elements in ascending order
    {
        public static void Main(string[] args)
        {
            int[] list = { 87, 66, 96, 25, 26 };
            Console.WriteLine("Original Unsorted List");
            
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Array.Sort(list);
            Console.WriteLine(" \nSorted List");
            
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
               
            }
        }
    }
}
