using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BookBusiness
    {
        private BookRepository bookRepository;

        public BookBusiness()
        {
            this.bookRepository = new BookRepository();
        }

        public List<Book> GetAllBooks()
        {
            return bookRepository.GetAllBooks();

        }

        public List<Book> GetAllBooksGTPages()
        {
            return bookRepository.GetAllBooks().Where(b => b.NumberOfPage > 50).ToList();

        }

        public bool InsertBook(Book b)
        {
            if (this.bookRepository.InsertBook(b)>0)
            {
                return true;
            }
            return false;
        }


    }
}
