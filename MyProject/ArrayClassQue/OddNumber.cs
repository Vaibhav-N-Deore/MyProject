using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayClassQue
{
    internal class OddNumber
    {
        static int getOddNumber(int[] arr, int arr_size)
        {
            int res = 0;
            for (int i = 0; i < arr_size; i++)
            {
                res = res ^ arr[i];
            }
            return res;
        }

        public static void Main()
        {
            int[] arr = { 2, 3, 5, 4, 5, 2, 4, 3, 5, 2, 4, 4, 2 };
            int n = arr.Length;
            Console.Write(getOddNumber(arr, n));
        }

    }
}
