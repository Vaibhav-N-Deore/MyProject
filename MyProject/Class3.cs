using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class persone //USE OF BASE KEYWORD 
    {

        protected string tel = "123-46-789";
        protected string name = "vaibhav deore";

        public virtual void GetInfo()
        {
            Console.WriteLine("tel:{0}",tel);
            Console.WriteLine("tel:{0}", tel);


        }
    }
}

   