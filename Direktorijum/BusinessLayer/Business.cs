using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Business
    {
        private readonly LibraryRepository libraryRepository;

        public Business()
        {
            this.libraryRepository = new LibraryRepository();
        }

        public List<Library> GetAllBooks()
        {
            return this.libraryRepository.GetAllBooks();
        }

        public List<Library> GetBooks(int x)
        {
            x = 50;
            return this.libraryRepository.GetAllBooks()
                .Where(l => l.NumberOfPages > x).ToList();
        }
    }
}
