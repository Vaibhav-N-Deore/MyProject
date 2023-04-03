using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Exception_Handling
{
    class MobileNumberExce
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile No.");
            long mobileNo = long.Parse(Console.ReadLine());
            int c = 0;
            while (mobileNo > 0)
            {
                c++;
                mobileNo = mobileNo / 10;
            }

            if (c != 10)
                Console.WriteLine("valid Mobile no.");
            else
                throw new InvalidMobileException("Mobile no. should be 10 digit");

        }
    }
    class InvalidMobileException : ApplicationException
    {
        public InvalidMobileException(string m) : base(m)
        {

        }
    }


}
