using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Oops
{
    class Book
    {
        public int bookQuantity = 15;
    }
    class Historical : Book
    {
        private int bookId = 1212;
        private string historicalbookName = "Shriman Yogi";
        public void showHistorical()
        {
            Console.WriteLine("Historical Book");
            Console.WriteLine("Book Id:" + bookId);
            Console.WriteLine("Book Quantity:" + bookQuantity);
            Console.WriteLine("Book Name:" + historicalbookName);
        }
    }
    class Biography : Book
    {
        public string biographybookName = "Wings Of Fire";
        public string biographyauthor = "A.P.J Abdul Kalam";
        public void showBiography()
        {
            Console.WriteLine("Biography");
            Console.WriteLine("Biography Name:" + biographybookName);
            Console.WriteLine("Biography Author:" + biographyauthor);

        }
    }
    class CookBook : Book
    {
        public string bookName = "Masterchef India";
        double rating = 4.5;
        public void showCookBook()
        {
            Console.WriteLine("CookBook");
            Console.WriteLine("Book Name:" + bookName);
            Console.WriteLine("Book rating:" + rating);

        }
    }
    class Demo1
    {
        static void Main(string[] args)
        {
            Historical historical = new Historical();
            historical.showHistorical();
            Biography bio = new Biography();
            bio.showBiography();
            CookBook cbook = new CookBook();
            cbook.showCookBook();
        }
    }

}
