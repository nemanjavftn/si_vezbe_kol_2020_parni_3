﻿using DataLayer;
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
        private readonly BookRepository bookRepository;

        public BookBusiness()
        {
            this.bookRepository = new BookRepository();
        }

        public List<Book> GetAllBooks()
        {
            return this.bookRepository.GetAllBooks().Where(b => b.NumberOfPages > 50).ToList();
        }

        public bool InsertBook(Book b)
        {
            if (this.bookRepository.InsertBook(b) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
