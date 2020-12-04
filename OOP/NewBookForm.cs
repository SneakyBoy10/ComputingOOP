using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class NewBookForm : Form
    {
        public bool newBookFinished = false;
        public static List<Book> BookList = new List<Book>(); 

        public NewBookForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            BookList.Add(new Book(BookList.Count + 1, txtTitle.Text, txtAuthor.Text, txtPublisher.Text, dtpDatePublished.Value));
            this.Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            newBookFinished = true;
            this.Close();
        }

        private void NewBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPublisher.Text = "";
            dtpDatePublished.Value = DateTime.Now;
        }
    }
}
