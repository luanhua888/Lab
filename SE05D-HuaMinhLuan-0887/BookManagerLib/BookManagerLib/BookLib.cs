using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerLib
{
    public class BookLib
    {
        public string BookId { get; set; }
        public string  BookName { get; set; }
        public string  Author { get; set; }
        public string Pulisher { get; set; }

        public BookLib(string bookid, string bookName, string author, string publisher)
        {
            this.BookId = bookid;
            this.BookName = bookName;
            this.Author = author;
            this.Pulisher = publisher;
        }

       
        public override string ToString()
        {
            return String.Format("| {0} | {1} | {2}  | {3}  |", BookId,BookName,Author,Pulisher);
        }
    }
        
    
}
