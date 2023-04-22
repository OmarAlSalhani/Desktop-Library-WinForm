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
    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ConnectionCLS.connection;
            command.CommandText = @"insert into MembersTable (member_name,member_address,member_phone)
                                                    values(@member_name,@member_address,@member_phone)";
            command.Parameters.AddWithValue("@member_name",NameTB.Text);
            command.Parameters.AddWithValue("member_address", AddressTB.Text);
            command.Parameters.AddWithValue("@member_phone", PhoneTB.Text);
            if(command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("تم الإضافة");
            }
        }
    }
}
