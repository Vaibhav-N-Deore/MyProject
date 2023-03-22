using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayObject.TwoDArray
{
    internal class Project1
    {
        class store
        {
            int part_id;
            string part_name;
            int price;
            string companyname;
            store[] part;

            public store()
            {

            }
            public store(int part_id, String part_name, int price, string companyname)
            {

            }
            public void Createstore(store[] b)
            {
                this.part = b;
            }
            public void Create1store(store[] b)
            {
                this.part = b;
            }
            public override string ToString()
            {
                return part_id + " " + part_name + " " + price + " " + companyname;
            }
            public void ShowAllPart()
            {
                //display all records from part array
                
            }
            public void ShowPartById(int id)
            {
                foreach (store bt in part)
                {
                    if (bt != null)
                    {
                        if (id == bt.part_id)
                        {
                            Console.WriteLine(bt);
                        }
                    }
                }

            }
            public void UpdatePart(int id)
            {

            }
            public void DeletePart(int id)
            {

            }
            class Project
            {
                static void Main(string[] args)
                {
                    store[] b = new store[3];

                    //logic too create array

                    store bk = new store();
                    bk.Createstore(b);
                    bk.ShowAllPart();
                    bk.ShowPartById(100);

                }
            }
        }
    }


}
