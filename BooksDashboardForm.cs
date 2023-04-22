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
    public partial class BooksDashboardForm : Form
    {
        public BooksDashboardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = @"
select
	  B.book_name As 'إسم الكتاب',
	  B.book_type as 'التصنيف',
	  B.book_price as 'السعر',
	  A.author_name 'إسم الكاتب',
	  A.author_address 'عنوان الكاتب', 
	  MT.member_name as 'إسم العضو' ,
	  MT.member_phone 'هاتف العضو',
      BT.borrowed_date 'تاريخ الإستعارة',
      BT.return_date AS 'تاريخ الإرجاع'
	  from BorrowedTable BT join BooksTable B on BT.book_name=B.book_name
	  join AuthorsTable A on A.author_name=B.book_author
	  join MembersTable MT on MT.member_name=BT.member_name
	  where B.book_on_hand=0";
            SqlDataAdapter adapter = new SqlDataAdapter(Query,ConnectionCLS.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gunaDataGridView1.DataSource = table;
        }

        private void ShowAvailableBtn_Click(object sender, EventArgs e)
        {
            string Query = @"
select 
      B.book_name as 'إسم الكتاب',
	  A.author_name as 'إسم الكاتب',
	  A.author_address as 'عنوان الكاتب',
	  B.book_type as 'التصنيف',
	  B.book_price as 'السعر'
	  from BooksTable B join AuthorsTable A on A.author_name=B.book_author
	  where B.book_on_hand=1";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, ConnectionCLS.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gunaDataGridView1.DataSource = table;
        }
    }
}
