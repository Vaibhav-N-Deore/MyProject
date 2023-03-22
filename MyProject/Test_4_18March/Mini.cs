/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_4_18March
{
    internal class Mini
    {
        static void Main(string[] args)
        {

            char[] arr = new char[] { 'a', 'b', 'b', 'c', 'c', 'e', 'e', 'b' };
            int n = arr.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine("frequency of " + arr);
                //Console.WriteLine(arr[i] + " " + count);
            }


        }
    }
}
*/