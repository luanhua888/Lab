using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagerLib;


namespace BookManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager bookst = new BookManager();
            string choosen;
            do {
                Console.WriteLine("\t\t\t\t\t\t************MENU************");
                Console.WriteLine("\t\t\t\t\t\t1. Add a book");
                Console.WriteLine("\t\t\t\t\t\t2. Find a book");
                Console.WriteLine("\t\t\t\t\t\t3. Remove a book");
                Console.WriteLine("\t\t\t\t\t\t4. Show list book");
                Console.WriteLine("\t\t\t\t\t\t5. Exit");
                Console.Write("\t\t\t\t\t\tPlease Enter your choosen: ");
                choosen = Console.ReadLine();

                switch (choosen) {
                    case "1":
                        BookLib newBook = InputInfo();
                        bookst.addBook(newBook);
                        break;
                    case "2":
                        Console.WriteLine("Please Enter Name Book You Want To Find: ");
                        string name = Console.ReadLine();
                        bookst.FindBook(name);
                        break;
                    case "3":
                        Console.WriteLine("Please enter ID Book you want to find: ");
                        string id = Console.ReadLine();
                        bookst.Remove(id);
                        break;
                    case "4":
                        bookst.showListBooks();
                        break;
                }
            } while (!choosen.Equals("5"));
        }

        static BookLib InputInfo()
        {
            string BookId1, BookName1, Author1, Publisher1;
            Console.WriteLine("Please Enter Information");
            Console.Write("Book ID:");
            BookId1 = Console.ReadLine();
            Console.Write("Book Name:");
            BookName1 = Console.ReadLine();
            Console.Write("Author:");
            Author1 = Console.ReadLine();
            Console.Write("Publisher:");
            Publisher1 = Console.ReadLine();
            return new BookLib(BookId1,BookName1,Author1,Publisher1); 
        }
    }
}
