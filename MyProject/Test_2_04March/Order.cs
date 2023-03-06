using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_2_04March
{
     class Order //Q.7
    {
        
            public string city= "Pune";
           
    }
        class HeadPhone : Order
        {
           public string customername = "vaibhav deore";
           private int customerID = 1111;
            public void showOrder()
            {
                Console.WriteLine("CustomerName:" + customername);
                Console.WriteLine("CustomerID:" + customerID);
                Console.WriteLine("City:"+city);

            }
        }
        class Delivery : Order
        {
            private bool delivered = true;
            public void showstatus()
            {
            if (delivered ==true)
            {
               Console.WriteLine("order is delivered");
            }
            else
            {
               Console.WriteLine("order is Not delivered");
            }

           // Console.WriteLine("Order:" + delivered);

            }
        }
        class Final
        {
            static void Main(string[] args)
            {
                HeadPhone hphone = new HeadPhone();
                hphone.showOrder();
                Delivery cha = new Delivery();
                cha.showstatus();
            }
        }
    
}
