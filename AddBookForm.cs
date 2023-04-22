using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryApp
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
           
            SqlDataAdapter adapter = new SqlDataAdapter("Select author_name from AuthorsTable", ConnectionCLS.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            AuthorCB.DataSource = table;
            AuthorCB.DisplayMember = "author_name";
            AuthorCB.ValueMember = "author_name";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ConnectionCLS.connection;
            command.CommandText = @"insert into BooksTable(book_name,book_type,book_price,book_author,book_on_hand)
                                              values(@book_name,@book_type,@book_price,@book_author,@book_on_hand)";
            command.Parameters.AddWithValue("@book_name",NameTB.Text);
            command.Parameters.AddWithValue("@book_type", TypeCB.Text);
            command.Parameters.AddWithValue("@book_price", Convert.ToInt32(PriceTB.Text));
            command.Parameters.AddWithValue("@book_author", AuthorCB.Text);
            command.Parameters.AddWithValue("@book_on_hand",1);
            if(command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("تمت عملية الأضافة");
            }
        }
    }
}
