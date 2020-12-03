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

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly BookBusiness bookBusiness;
        public Form1()
        {
            this.bookBusiness = new BookBusiness();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            List<Book> books = this.bookBusiness.GetAllBooks();
            lbBooks.Items.Clear();

            foreach (Book b in books)
            {
                lbBooks.Items.Add(b.Id + ". " + b.Name + "(" + b.NumberOfPages + ")");
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.Name = tbName.Text;
            b.NumberOfPages = Convert.ToInt32(tbNumber.Text);
           

            if (this.bookBusiness.InsertBook(b))
            {
                RefreshData();
                tbName.Text = "";
                tbNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Greska!");
            }
        }
    }
}
