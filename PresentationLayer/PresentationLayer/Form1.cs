using BusinessLayer;
using DataLayer;
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
        private BookBusiness bookBusiness;
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
            List<Book> books = this.bookBusiness.GetBooks();
            listBoxBiblioteka.Items.Clear();
            foreach (Book b in books)
            {
                listBoxBiblioteka.Items.Add(b.Id + "." + b.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.Name = textBoxName.Text;
            b.NumberOfPages = Convert.ToInt32(textBoxNOP.Text);
            if (bookBusiness.InsertBook(b) == true)
                RefreshData();
            else
                MessageBox.Show("Greska");
        }
    }
}
