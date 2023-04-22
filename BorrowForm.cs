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
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ConnectionCLS.connection;
            command.CommandText = "insert into BorrowedTable (book_name,member_name,borrowed_date,return_date)" +
                "                                     values(@book_name,@member_name,@borrowed_date,@return_date)";
            command.Parameters.AddWithValue("@book_name",BookNameCB.Text);
            command.Parameters.AddWithValue("@member_name", MemberNameCB.Text);
            command.Parameters.AddWithValue("@borrowed_date", BorrowedDate.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@return_date", ReturnDate.Value.ToString("yyyy-MM-dd"));
            SqlCommand command1 = new SqlCommand();
            command1.Connection = ConnectionCLS.connection;
            command1.CommandText = @"update BooksTable Set book_on_hand=0 where book_name='" + BookNameCB.Text + "'";
            if(command.ExecuteNonQuery()==1 && command1.ExecuteNonQuery()==1)
            {
                MessageBox.Show("تمت الإضافة");
            }               
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter1 = new SqlDataAdapter("Select book_name From BooksTable where book_on_hand=1", ConnectionCLS.connection);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);
            BookNameCB.DataSource = table1;
            BookNameCB.DisplayMember = "book_name";
            BookNameCB.ValueMember = "book_name";
            SqlDataAdapter adapter2 = new SqlDataAdapter("Select member_name from MembersTable", ConnectionCLS.connection);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            MemberNameCB.DataSource = table2;
            MemberNameCB.DisplayMember = "member_name";
            MemberNameCB.ValueMember = "member_name";
        }
    }
}
