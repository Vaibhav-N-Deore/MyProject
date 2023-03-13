using MyProject.Inheritan.MultiLevel_Inhe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_3_11March
{
    internal class NationalGame
    {
        static void Main(string[] args)
        {
            int Game;
            Console.WriteLine("Press 1 for India\n");
            Console.WriteLine("Press 2 for China\n");
            Console.WriteLine("Press 3 for Bangladesh\n");
            Console.WriteLine("Press 4 for Italy\n");
            Console.WriteLine("Press 5 for United States\n");
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("--------------------------------");

            Game = Convert.ToInt32(Console.ReadLine());


            switch (Game)
            {
                case 1:
                    Console.WriteLine("National game of India is :- Hockey");
                    break;
                case 2:
                    Console.WriteLine("National game of China is :- Table Tennis");
                    break;
                case 3:
                    Console.WriteLine("National game of Bangladesh is :- Kabaddi");
                    break;
                case 4:
                    Console.WriteLine("National game of Italy is :- Football");
                    break;
                case 5:
                    Console.WriteLine("National game of United States is :- Baseball");
                    break;
                default :
                    Console.WriteLine("error");
                    break;

            }
            Console.Read();
        }
    }
}
