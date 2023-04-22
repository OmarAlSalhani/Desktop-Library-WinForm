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
    public partial class AuthorsForm : Form
    {
        public AuthorsForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ConnectionCLS.connection;
            command.CommandText = @"insert into AuthorsTable(author_name,author_address)
                                                      values(@author_name,@author_address)";
            command.Parameters.AddWithValue("@author_name", NameTB.Text);
            command.Parameters.AddWithValue("@author_address", AddressTB.Text);
            if(command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("تمت الأضافة");
            }
        }
    }
}
