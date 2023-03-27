using MyProject.Test_4_18March;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_5_25March
{
    internal class UniqueArray  //Q.WAP to print all unique elements in the array
    {
        static void Main(string[] args)
        {

            int[] items = { 2, 3, 5, 3, 7, 5 };
            int n = items.Length;

            Console.WriteLine("Unique array elements: ");

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (items[i] == items[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(items[i]);

                }
            }

                Console.ReadLine();
        }    
    }

}
