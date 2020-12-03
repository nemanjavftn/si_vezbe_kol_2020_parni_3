using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormLibary : Form
    {
        private BookBusiness bookBusiness;
        public FormLibary()
        {
            InitializeComponent();
            this.bookBusiness = new BookBusiness();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataRefresh();
        }

        private void DataRefresh()
        {
            
            List<Book> listOfBooks = this.bookBusiness.GetAllBooks();
            listBoxBooks.Items.Clear();

            foreach (Book b in listOfBooks)
            {
                listBoxBooks.Items.Add(b.Id + "." + " " + b.Name);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.Name = textBoxName.Text;
            b.NumberOfPage = Convert.ToInt32(textBoxNumberOfPages.Text);
            
            if (this.bookBusiness.InsertBook(b))
            {
                DataRefresh();
                textBoxName.Text = "";
                textBoxNumberOfPages.Text = "";
            }
            else
            {
                MessageBox.Show("Greska!");
            }
        }
    }
}
