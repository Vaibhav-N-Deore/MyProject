/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_3_11March
{
   class Shopping { 
            static string DoTransation(string a )
             {
                 Console.WriteLine("you got 15% discount : " + a);
             }
            static string DoTransation(string b)
             {
                 Console.WriteLine("No discount: " + b);
             }

              static void Main(string[] args)
             {

                 string v1 = DoTransation('CreditCard');
                 string v2 = DoTransation('DebitCard');
                 Console.WriteLine("string: "+ v1);
                 Console.WriteLine("string: "+ v2);
             }

     }


    class Shopping
    {
        
        public void doTransation(string CreditCard)
        {
            Console.WriteLine("You got 15% discount on bill on credit card transaction");
        }
        public void doTransation(string DebitCard,string CreditCard)
        {
            Console.WriteLine("‘No discount non bill on debit card transaction’");
        }
    }
    class Method1
    {
        static void Main(string[] args)
        {
            string type;
            Shopping oo = new Shopping();
            Console.WriteLine("Enter Type of card");
            type = Console.ReadLine();

            if (type == "CreditCard")
            {
                oo.doTransation("credit");
            }
            else
            {
                oo.doTransation("debit ", " credit");
            }
            
           
            Console.ReadLine();
        }

    }
}
*/