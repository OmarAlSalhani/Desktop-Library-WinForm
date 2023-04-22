using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BooksDashboardForm form = new BooksDashboardForm();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MembersForm membersForm = new MembersForm();
            membersForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthorsForm authorsForm = new AuthorsForm();
            authorsForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectionCLS.Open();
        }
    }
}
