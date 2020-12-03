
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BookBusiness
    {
        private readonly BookRepository bookRepository;
        public BookBusiness()
        {
            this.bookRepository = new BookRepository();

        }
        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            List<Book> books2 = bookRepository.GetAllBooks();
            foreach(Book b in books)
            {
                if (b.NumberOfPages > 50)
                    books.Add(b);

            }
            return books2;

        }
        public bool InsertBook(Book b)
        {
            if (this.bookRepository.InsertBook(b) > 0)
                return true;
            else
                return false;
        }
    }
}
