using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Oops
{
    class Medico
    {
        private int MedicalId = 0101;
        public string location = "Pune";
        public void showMedico()
        {
            Console.WriteLine("Medico Info");
            Console.WriteLine("Medical Id: "+MedicalId);
            Console.WriteLine("Location: " + location);

        }
    }
    class tablet:Medico
    {
        public string tabName = "Paracetamol";
        public int tabId = 01;
        public void showtablet()
        {
            Console.WriteLine("Tablet Info");
            Console.WriteLine("Tablet Id: " + tabId);
            Console.WriteLine("Tablet Name: " + tabName);

        }
    }
    class cosmatic : Medico
    {
        public string creamName = "Hand Cream";
        public double prize = 355;
        public double rating = 4.3;
        public void showcosmatic()
        {
            Console.WriteLine("Cosmatic Info");
            Console.WriteLine("Cream Name: " + creamName);
            Console.WriteLine("Prize: " + prize);
            Console.WriteLine("Rating:"+rating);
        }
    }
    class Medical
    {
        static void Main(string[] args)
        {
            Medico m = new Medico();
            m.showMedico();
            cosmatic c = new cosmatic();
            c.showcosmatic();
            tablet t = new tablet();
            t.showtablet();
            
        }
    }
    
}
