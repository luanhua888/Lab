using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagerLib;
namespace BookManagerLib
{
    public class BookManager
    {
        List<BookLib> list;
        public BookManager()
        {
            list = new List<BookLib>();
        }

        private void showListBook(List<BookLib> bookList)
        {
            if (bookList.Count > 0) {
                foreach (BookLib item in bookList) {
                    Console.WriteLine(item.ToString());
                }
            }
            else {
                Console.WriteLine("No Have Books");
            }
        }
        public void showListBooks()
        {
            showListBook(list);
        }
        public void addBook(BookLib book)
        {
            try {
                if (checkId(book.BookId)) {
                    Console.WriteLine("Add fail, ID already exists");
                }
                list.Add(book);
                Console.WriteLine("Add successfully");
            }
            catch (Exception) {

                Console.WriteLine("Add Fail :V");
            }
        }

        private Boolean checkId(string BookID1)
        {
            foreach (BookLib item in list) {
                if (item.BookId.Equals(BookID1)) {
                    return true;
                }
            }
            return false;
        }

        public void FindBook(string nameBook)
        {
            List<BookLib> listFind = new List<BookLib>();
            foreach (BookLib item in list) {
                if (item.BookName.Contains(nameBook)) {
                    listFind.Add(item);
                }
            }

            showListBook(listFind);
        }

        public void Remove(string bookId)
        {
            foreach(BookLib item in list) {

                if (item.BookId.Equals(bookId)) {
                    list.Remove(item);
                    Console.WriteLine("Remove Successfully");
                    return;
                }
            }
            Console.WriteLine("Remove Fail");
        }

    }


}
