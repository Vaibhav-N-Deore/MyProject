/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_4_18March
{
    internal class Containment
    {
        class Car
        {
            int Carid;
            string Carcolor;
            int engineid;
            string lastenginecleandate;
            string subenginetype;
            Batch batch = new Batch();
            Engine address = new Engine();
            public Car()
            {

            }

            public Car(int carid, string carcolor)
            {
                this.Carid = carid;
                this.Carcolor = carcolor;
               
            }

            public int carid { get => carid; set => carid = value; }
            public string carcolor { get => carcolor; set => carcolor = value; }
         
        }
        class Engine
        {
            int engineid;
            string lastenginecleandate;

            public Engine()
            {

            }
            public Engine(int engineid, string lastenginecleandate)
            {
                this.engineid = engineid;
                this.lastenginecleandate = lastenginecleandate;
            }

            public int engineid { get => engineid; set => engineid = value; }
            public string lastenginecleandate { get => lastenginecleandate; set => lastenginecleandate = value; }
        }
        class SubEngine
        {
            string subenginetype;

            public string subenginetype { get => petrol; set => diesel = value; }
           

            public Type()
            {

            }
            public Type(string petrol, string diesel)
            {

            }


        }
        class Gear:Car
        {
            static void Main(string[] args)
            {
                Car cr = new Car();
                cr.carid = 1;
                cr.carcolor = "black";
                cr.lastenginecleandate = "servicing date";
               
                Console.WriteLine("car id " + cr.carid);
                Console.WriteLine("car color " + cr.carcolor);
                Console.WriteLine("latestenginecleandate " + cr.latestenginecleandate);
                Console.WriteLine("subenginetype " + cr.subenginetype);
               

                Console.ReadLine();
            }
        }
    }
}
*/