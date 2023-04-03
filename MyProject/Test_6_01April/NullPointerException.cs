using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_6_01April
{
    internal class NullPointerException   //Q.WAP to generate NullPointerException ? 
    {
        public static void Main(string[] args)
        {
            string ptr = null;

            try
            {
                if (ptr.Equals("C#"))
                {
                    Console.WriteLine("Equal");
                }
                else
                {
                    Console.WriteLine("Not Equal");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception Found : "+e);
            }
            Console.ReadKey();
        }
    }
}
