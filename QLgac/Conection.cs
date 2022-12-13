using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLgac
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=MSI\HOADINH;Initial Catalog=HTTT;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }

        private SqlConnection connection = new SqlConnection(@"Data Source=MSI\HOADINH;Initial Catalog=HTTT;Integrated Security=True");

        public SqlConnection GetCon()
        {
            return connection;
        }

    }
}
