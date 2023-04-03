using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_6_01April
{
    internal class Throw   // Q.What is the throw keyword
    {
        static void Main()
        {
       
            try
            {
                V();
                D(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void V()
        {
            // Rethrow syntax.
            try
            {
                int value = 1 / int.Parse("0");
            }
            catch
            {
                throw;
            }
        }
        static void D(string value)
        {
            // Generate new exception.
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
        }
    }
}
