using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly BookBL book;
        public Form1()
        {
            this.book = new BookBL();
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            listBoxBooks.Items.Clear();
            List<Book> books = this.book.GetAllBooks();
            foreach(Book b in books)
            {
                listBoxBooks.Items.Add(b.Id + " " + b.Name);
            }
        }
        private void addBook_Click(object sender, EventArgs e)
        {
            Book objBook = new Book();
            objBook.Name = nameBook.Text;
            objBook.NumberOfpages = Convert.ToInt32(numberBook.Text);

            if (this.book.InsertBook(objBook) > 0)
            {
                MessageBox.Show("Uspesan unos");
                Fill();
            }
            else
                MessageBox.Show("Napravili ste gresku. Pokusajte ponovo");
        }
    }
}
