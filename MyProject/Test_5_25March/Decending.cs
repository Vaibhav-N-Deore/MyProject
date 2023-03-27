using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_5_25March
{
    internal class Decending   //Q.Create an array of 10 names sort in descending order
    {
        public static void Main()
        {

                                                 // declaring & initializing the array
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9, 4, 2, 3, 8 };

                                                 // ascending
            Array.Sort(arr);
            Console.WriteLine("Ascending: ");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

                                                    // Desending /reverse array
            Array.Reverse(arr);
            Console.WriteLine("\n\nDescending: ");
           
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}

    

