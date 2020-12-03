using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BookBL
    {
        private readonly BookRepository book;

        public BookBL()
        {
            this.book = new BookRepository();
        }

        public List<Book> GetAllBooks()
        {
            return this.book.GetAllBooks();
        }
        public List<Book> GetBooksByNumberPages()
        {
            return this.book.GetAllBooks().Where(b => b.NumberOfpages > 50).ToList();
        }
        public int InsertBook(Book book)
        {
            return this.book.InsertBook(book);
        }
    }
}
