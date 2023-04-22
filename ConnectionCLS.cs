using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LibraryApp
{
    class ConnectionCLS
    {
        public static SqlConnection connection = new SqlConnection("Server=DESKTOP-BH4UIKI;Database=LibraryDB;Integrated Security=true");
        public static void Open()
        {
            connection.Open();
        }
    }
}
