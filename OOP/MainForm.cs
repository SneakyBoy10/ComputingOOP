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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnAddBookMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newBookForm = new NewBookForm();
            while (newBookForm.newBookFinished == false)
            {
                newBookForm.ShowDialog();
            }
            this.Show();
        }

        private void btnViewBookMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var viewBooksForm = new ViewBooksForm();
            while (viewBooksForm.viewBooksFinished == false)
            {
                viewBooksForm.ShowDialog();
            }
            this.Show();
        }
    }
}
