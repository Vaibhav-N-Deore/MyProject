/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AbstractInteface
{
    internal class IMobileable
    {
        public static string company;
        public static int size;

        public void DisplayInfo();
    }

    internal interface IConfigurationable : IMobileable
    {
        public static int proccesor;
        public static string os;
        public static int system;

        public void showInfo();  
    }

    internal class merge : IConfigurationable
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Name of company: "+ IMobileable.company);
            Console.WriteLine("size: "+ IMobileable.size);
        }

        public void ShowInfo()
        {
            Console.WriteLine("proccesor is: " + IConfigurationable.proccesor);
            Console.WriteLine("size: " + IConfigurationable.size);
            Console.WriteLine("operating system: "+ IConfigurationable.os);
           
        }
        internal class user
        {
            static void Main(string[] args)
            {

                merge m = new merge();

                Console.WriteLine("Enter name:");
                IMobileable.company = Console.ReadLine(); 
                Console.WriteLine("Enter size ,");
                IMobileable.size = int.Parse(Console.ReadLine());

              
                Console.WriteLine("Enter the proccesor: ");
                IConfigurationable.proccesor = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the size: ");
                IConfigurationable.size = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the system name: "); 
                IConfigurationable.system = Console.ReadLine();

                m.DisplayInfo();
                m.ShowInfo();
            }
        }

    }


}
*/