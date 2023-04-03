using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Exception_Handling
{
    internal class MultiCatch
    {

        static void Main(string[] args)
        {
            int x = 0;
            int div = 0;

            try
            {
                div = 100 / x;
                Console.WriteLine("Line Not executed ");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine($"Result is :");

        }


    }
}
