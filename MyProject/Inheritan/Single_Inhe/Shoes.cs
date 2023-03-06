using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Inheritan.Single_Inhe
{
        public class shoes
        {
            public void Displayshoes()
            {
                Console.WriteLine("shoes");
            }
        }

        public class Nike : shoes
        {
            public void DisplayNike()
            {
                Console.WriteLine("Nike");
            }
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                Nike s = new Nike();
                s.DisplayNike();
                s.Displayshoes();
            }
        }
    
}
