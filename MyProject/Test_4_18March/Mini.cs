using System;
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
            static void Main(string[] args)
            {
                
                char min;
                char[] arr = new char[] { 'a', 'd', 'a', 'r', 'e' };

                min = arr[0];

                for (int i = 0; i < 0; i++)
                {
                    

                        if (arr[i] < min)
                        {
                            min = arr[i];
                        }

                }

                Console.Write("Array alpha\n");
                for (int i = 0; i <0; i++)
                {
                  
                        Console.Write(arr[i] + " ,");
                  
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("Minimum  alpha:" + min);
                Console.ReadLine();
            }
        }
    }
}
