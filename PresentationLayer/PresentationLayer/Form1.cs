using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataAccessLayer;
using DataAccessLayer.Models;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly BookBusiness bookBusiness;
        private readonly BookRepository bookRepository;
        public Form1()
        {
            this.bookBusiness = new BookBusiness();
            this.bookRepository = new BookRepository();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();

        }

        public void RefreshData()
        {
            List<Book> v = this.bookRepository.GetAllBooks();
            listBoxBooks.Items.Clear();

            foreach (Book books in v)
                listBoxBooks.Items.Add(books.Id + ". " + books.Name + "- " + books.NumberOfPages);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.Name = textBoxName.Text;
            b.NumberOfPages = Convert.ToInt32(textBoxNumberOfPages.Text);

            if (this.bookBusiness.InsertBook(b))
            {
                RefreshData();
                textBoxName.Text = "";
                textBoxNumberOfPages.Text = "";
            }
            else
            {
                MessageBox.Show("Greska");
            }
        }

       
    }
}
