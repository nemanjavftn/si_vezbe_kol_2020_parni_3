using DataAccessLayer;
using DataAccessLayer.Models;
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

        public bool InsertBook(Book b)
        {
            if (this.bookRepository.InsertBook(b) > 0)
                return true;
            return false;
        }

        public List<Book> GetAllBooksGTPages(int nop)
        {
            return this.bookRepository.GetAllBooks().Where(item => item.NumberOfPages > 50).ToList();
        }

    }
}
