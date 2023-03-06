using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_2_04March
{
    internal class Fact //Q.2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.Read());
            for (int i=1; i<=n; i++)
            {
                if(n%i==0)
                Console.WriteLine();
            }
        }
    }
}
