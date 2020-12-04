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
    public partial class ViewBooksForm : Form
    {
        public bool viewBooksFinished = false;

        public ViewBooksForm()
        {
            InitializeComponent();
        }

        private void ViewBooksForm_Load(object sender, EventArgs e)
        {
            foreach(Book book in NewBookForm.BookList)
            {
                dgvBooks.Rows.Add(book.bookID, book.title, book.author, book.publisher, book.datePublished, "Delete");
            }
        }

        private void ViewBooksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            viewBooksFinished = true;
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvBooks.Rows[e.RowIndex];
            var cell = row.Cells[e.ColumnIndex];
            if(cell is DataGridViewButtonCell)
            {
                NewBookForm.BookList.RemoveAt(e.RowIndex);
                dgvBooks.Rows.Remove(row);
            }
        }
    }
}
