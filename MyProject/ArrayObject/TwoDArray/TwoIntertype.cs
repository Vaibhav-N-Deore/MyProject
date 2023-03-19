using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayObject.TwoDArray
{
    class TwoIntertype
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            Console.WriteLine("Array is " + array);
            int size = array.Length;
            Console.WriteLine(" ");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    //Console.WriteLine(array[i][j] + " ");

                }
            }
            Console.ReadLine();
        }
    }
}
