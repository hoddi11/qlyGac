using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLgac.DAO
{
    public class DataProvider
    {
        static string provider = @"Data Source=DESKTOP-CM6N3SA\SQLEXPRESS;Initial Catalog=QLGac;Integrated Security=True";
        protected SqlConnection connect = new SqlConnection(provider);

        public DataTable GetData(string sql)
        {
            DataTable rs = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            adapter.Fill(rs);
            return rs;
        }

        public void validateTest(string sql)
        {
            string printOutput = "";
            StringBuilder errorMessages = new StringBuilder();

            SqlCommand command = new SqlCommand(sql, connect);


            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                printOutput += (errorMessages.ToString());
            }
            if (printOutput != "")
            {
                MessageBox.Show(printOutput);
            }
            connect.Close();



        }

        public SqlDataAdapter GetDataSet(string sql)
        {

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);

            return adapter;
        }

        public void Excute(string sql)
        {

            SqlCommand command = new SqlCommand(sql, connect);

            string printOutput = "";
            StringBuilder errorMessages = new StringBuilder();

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                printOutput += (errorMessages.ToString());
            }

            if (printOutput != "")
            {
                MessageBox.Show(printOutput);
            }
            connect.Close();
        }

        public void ExcuteWithParam(string sql, SqlParameter[] listParam)
        {

            SqlCommand command = new SqlCommand(sql, connect);

            foreach (var i in listParam)
            {
                command.Parameters.Add(i);
            }

            string printOutput = "";
            StringBuilder errorMessages = new StringBuilder();

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                printOutput += (errorMessages.ToString());
            }
            finally
            {
                connect.Close();

            }

            if (printOutput != "")
            {
                MessageBox.Show(printOutput);
            }
        }



        public void Excute_Proc_NParam(string NameProc, SqlParameter[] listParam)
        {
            try
            {

                SqlCommand command = new SqlCommand(NameProc, connect);
                command.CommandType = CommandType.StoredProcedure;

                foreach (var i in listParam)
                {
                    command.Parameters.Add(i);
                }

                string printOutput = "";
                StringBuilder errorMessages = new StringBuilder();

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    printOutput += (errorMessages.ToString());
                }

                if (printOutput != "")
                {
                    MessageBox.Show(printOutput);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
        }


        public DataTable GetData_Proc_NParam(string NameProc, SqlParameter[] listParam)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(NameProc, connect);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (var i in listParam)
                {
                    cmd.Parameters.Add(i);
                }

                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
        }

        public string GetString_Proc_NParam(string NameProc, SqlParameter[] listParam)
        {

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(NameProc, connect);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (var i in listParam)
                {
                    cmd.Parameters.Add(i);
                }

                string res = (string)cmd.ExecuteScalar();
                return res;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
        }


        public int GetINT_Proc_NParam(string NameProc, SqlParameter[] listParam)
        {

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(NameProc, connect);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (var i in listParam)
                {
                    cmd.Parameters.Add(i);
                }

                Int32 count = (Int32)cmd.ExecuteScalar();
                return (int)count;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
        }



        public byte[] LoadImage(string sql)
        {

            if (connect.State != ConnectionState.Open)
                connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            byte[] imgbin = new byte[100000000];
            if (reader.HasRows && !Convert.IsDBNull(reader[0]))
            {
                imgbin = (byte[])reader[0];
            }
            else
            {
                imgbin = new byte[0];
            }
            connect.Close();
            return imgbin;
        }

        public Int64 GetCount(string sql)
        {
            if (connect.State != ConnectionState.Open)
                connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            Int32 count = (Int32)command.ExecuteScalar();
            connect.Close();
            return count;

        }
        public long GetCount1(string sql)
        {
            if (connect.State != ConnectionState.Open)
                connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            long count = (long)command.ExecuteScalar();
            connect.Close();
            return count;

        }
        public string GetString(string sql)
        {
            if (connect.State != ConnectionState.Open)
                connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            string res = (string)command.ExecuteScalar();
            connect.Close();
            return res;
        }

        public string DateToString(Nullable<DateTime> d)
        {

            if (d != null) return d.Value.ToString("yyyy/MM/dd");
            return "";

        }
        public DataSet chart(string sql)
        {
            connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }


        public string FindLike(string sth)
        {
            if (sth != "")
            {
                return $"%{sth}%";

            }

            return sth;
        }
    }
}
