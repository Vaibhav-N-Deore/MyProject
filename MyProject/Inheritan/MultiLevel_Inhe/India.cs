using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Inheritan.MultiLevel_Inhe
{
        class India //multilevel
        {
            public int Area = 0;

        }

        class Maharashtra : India
        {
            public void showMaharashtra()
            {
                Console.WriteLine("Maharashtra " + "Area= " + Area);
            }
        }
        class Gujrat : India
        {
            public void showGujrat()
            {
                Console.WriteLine("Gujrat " + "Area= " + Area);
            }
        }

        class kerala : India
        {
            public void showkerala()
            {
                Console.WriteLine("kerala " + "Area= " + Area);
            }
        }
        class HirachicalDemo
        {
            static void Main(string[] args)
            {
                Maharashtra m = new Maharashtra();
                m.showMaharashtra();
                Gujrat g = new Gujrat();
                g.showGujrat();
                kerala k = new kerala();
                k.showkerala();

            }
        }
    
}
