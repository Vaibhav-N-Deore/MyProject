using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayAssignment
{
    internal class MoveNegPos  //Q.WAP to arrange the elements of an given array of integers where 
                               //all negative integers appear before all the positive integers.
                              
    {
        public static void move(int[] arr)
        {
            Array.Sort(arr);
        }

        // Driver code
        public static void Main()
        {
            int[] arr = { -1, 2, -3, 4, 5, 6, -7, 8, 9 };
            move(arr);
            foreach (int e in arr)
                Console.Write(e + " ");
        }
    }
   

}
