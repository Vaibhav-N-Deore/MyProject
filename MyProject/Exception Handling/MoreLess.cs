using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Exception_Handling
{
    internal class MoreLess
    {
        class DigitException : Exception
        {
            public DigitException() 
            {
                Console.WriteLine("");
            }
            public DigitException(string msg) : base(msg)
            {

            }
        }
    }
}
