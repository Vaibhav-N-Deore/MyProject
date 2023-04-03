using MyProject.Loop;
using MyProject.Oops;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_6_01April
{
    internal class Test
    {
        int count = 0;

        void A()
        {
            try
            {
                count++;

                try
                {
                    count++;

                    try
                    {
                        count++;
                        throw new Exception();

                    }

                    catch (Exception ex)
                    {
                        count++;
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    count++;
                }
            }

            catch (Exception ex)
            {
                count++;
            }

        }

        void display()
        {
            Console.WriteLine(count);
        }

        static void main(String[] args)
        {
            Test obj = new Test();
            obj.A();
            obj.display();
        }
    }



}

