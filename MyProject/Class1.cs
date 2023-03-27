using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Class1 // write code factore of given parameter 
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }


        }
    }
}
