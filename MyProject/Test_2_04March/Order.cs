using MyProject.Test_2_04March;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_2_04March
{
    class Order //Q.7
    {

        public string city = "Pune";

    }
    class HeadPhone : Order
    {
        public string customername = "vaibhav deore";
        private int customerID = 1111;
        public void showOrder()
        {
            Console.WriteLine("CustomerName:" + customername);
            Console.WriteLine("CustomerID:" + customerID);
            Console.WriteLine("City:" + city);

        }
    }
    class Delivery : Order
    {
        private bool delivered = true;
        public void showstatus()
        {
            if (delivered == true)
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

    internal class Order1
    {
        private int order_id;
        private string city;
        private string cust_name;
        private string is_delivered;

        public int Order_Id
        {
            set { order_id = value; }
            get { return order_id; }
        }

        private string City
        {
            set { city = value; }
            get { return city; }
        }

        private string Cust_Name
        {
            set { cust_name = value; }
            get { return cust_name; }
        }

        private string Is_Delivered
        {
            set { is_delivered = value; }
            get { return is_delivered; }
        }
    }

    /*internal class TestOrder
    {
       static void Main(string[] args)
        {
            Order o = new Order();
            o.Order_Id = 123;
            o.City = "Malegaon";
            o.Cust_Name = "vaibhav deore";
            o.Is_delivered = "Yes";

            Console.WriteLine(o.Order_Id + "\t" + o.city + "\t" + o.Cust_Name + "\t" + o.Is_Delivered);
        }

    }*/


}
