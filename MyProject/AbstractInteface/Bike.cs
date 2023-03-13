using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AbstractInteface
{
    internal abstract class Bike
    {
        public abstract void Run();
    }

    internal abstract class Unicorn : Bike
    {
        public abstract void servicing();
    }
    internal class vehicle : Unicorn
    {
        public override void servicing()
        {
            Console.WriteLine("in unicorn ");
        }

        public override void Run()
        {
            Console.WriteLine("in Bikes");
        }
    }
    internal class main
    {
        static void Main(string[] args)
        {
            vehicle ve = new vehicle();
            ve.Run();
            ve.servicing();
        }
    }
}
