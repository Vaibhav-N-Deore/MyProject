using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Oops
{
    class Bag
    {
        public int bagQuantity = 10;
    }
    class AmericanTourist : Bag
    {
        public string bagColor = "Black";
        public void showAmericanTourist()
        {
            Console.WriteLine("American Tourist Bag Quantity:" + bagQuantity);
            Console.WriteLine("American Tourist Bag Color:" + bagColor);
        }
    }
    class Gucci : Bag
    {
        public string material = "Leather";
        double rating = 4.5;
        public void showGucci()
        {
            Console.WriteLine("Gucci");
            Console.WriteLine("Bag Quantity:" + bagQuantity);
            Console.WriteLine("Bag Material:" + material + ", Rating:" + rating);

        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            Gucci gucci = new Gucci();
            gucci.showGucci();
            AmericanTourist atourist = new AmericanTourist();
            atourist.showAmericanTourist();
        }
    }

    

}
