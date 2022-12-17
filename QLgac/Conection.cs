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
        private static string stringConnection = @"Data Source=DESKTOP-CM6N3SA\SQLEXPRESS;Initial Catalog=QLGac;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }

        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CM6N3SA\SQLEXPRESS;Initial Catalog=QLGac;Integrated Security=True");

        public SqlConnection GetCon()
        {
            return connection;
        }

    }
}
