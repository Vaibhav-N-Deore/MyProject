using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayAssignment
{
   class IndexFind    //Q.WAP to search for a given number in an array and accordingly print the index if exists
    {

        // Function to find insert position of F
        static int find_index(int[] arr, int n, int F)
        {

            // Lower and upper bounds
            int start = 0;
            int end = n - 1;

            // Traverse the search space
            while (start <= end)
            {
                int mid = (start + end) / 2;

                // If F is found
                if (arr[mid] == F)
                    return mid;

                else if (arr[mid] < F)
                    start = mid + 1;

                else
                    end = mid - 1;
            }

            // Return insert position
            return end + 1;
        }

        // Driver Code
        public static void Main()
        {
            int[] arr = { 1, 3, 5, 6 };
            int n = arr.Length;
            int F = 2;

            Console.WriteLine(find_index(arr, n, F));
        }
    }

   

}
