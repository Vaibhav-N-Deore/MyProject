using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayAssignment
{
    internal class EqualArray  //Q. WAP to test the equality of two arrays.Means e.g arr1[] = [12, 22, 32, 42, 52, 62]
                               // and arr2[] = [52, 22, 62, 12, 42, 22] Here both arrays are equal.
    {
        static bool ArraysEqual(List<int> a, List<int> b)
        {
            // Sort both arrays and compare them using the SequenceEqual method
            return a.OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
        }

        public static void Main()
        {
            // Initialize two lists of integers

            List<int> a = new List<int> { 3, 2, 1, 3, 2, 1 };
            List<int> b = new List<int> { 1, 2, 3, 1, 2, 3 };


            Console.WriteLine(ArraysEqual(a, b) ? "True" : "False");
            Console.WriteLine(ArraysEqual(b, a) ? "True" : "False");
        }
    }

}

