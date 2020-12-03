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
        public Form1()
        {
            InitializeComponent();
        }

        private readonly LibraryBusiness libraryBusiness;
        public Form1()
        {
            this.libraryBusiness = new LibraryBusiness();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }



        private void RefreshData()
        {
            List<Library> lib = this.libraryBusiness.GetAllBooks();
            lisBbox1.Items.Clear();

            foreach (Library l in Books)
            {
                listBox1.Items.Add(l.Id + ". " + l.Name + "(" + l.NumberOfPages + ") - " );
            }
        }

    }
}
