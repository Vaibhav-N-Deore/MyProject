using MyProject.Oops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayObject.TwoDArray
{
    internal class Project
    {
        class Book
        {
            int book_id;
            string book_name;
            int price;
            string authorname;
            Book[] book;

            public Book()
            {

            }
            public Book(int book_id, String book_name, int price, string authorname)
            {

            }
            public void CreatBook(Book[] b)
            {
                this.book = b;
            }
            public void CreaeBook(Book[] b)
            {
                this.book = b;
            }
            public override string ToString()
            {
                return book_id + " " + book_name + " " + price + " " + authorname;
            }
            public void ShowAllBooks()
            {
                //display all records from book array
            }
            public void ShowBookById(int id)
            {
                foreach (Book bt in book)
                {
                    if (bt != null)
                    {
                        if (id == bt.book_id)
                        {
                            Console.WriteLine(bt);
                        }
                    }
                }

            }
            public void UpdateBook(int id)
            {

            }
            public void DeleteBook(int id)
            {

            }
            class Project
            {
                static void Main(string[] args)
                {
                    Book[] b = new Book[3]; 

                    //logic too create array

                    Book bk = new Book(); 
                    bk.CreaeBook(b); 
                    bk.ShowAllBooks(); 
                    bk.ShowBookById(100);

                }
            }
        }
    }
                    

                  

}

                












