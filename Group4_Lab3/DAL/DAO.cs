using Group5_Lab3.DTL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5_Lab3.DAL
{
    class DAO
    {
        static string strConn = ConfigurationManager.ConnectionStrings["LibraryConnectionString"].ConnectionString;
        static public DataTable GetDataTable(string sqlSelect)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                SqlDataAdapter da = new SqlDataAdapter(sqlSelect, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
        }

        static public bool UpdateTable(SqlCommand cmd)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }

        static public int GetInt(string queryString)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = queryString;
                    // cmd.Parameters.AddWithValue("@Name", "ABC");
                    var id = cmd.ExecuteScalar();
                    conn.Close();
                    return int.Parse(id.ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return -1;

            }


        }

        static public Copy GetCopyNumber(int copyNumber)
        {
            using (SqlConnection con = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Copy where copyNumber = " + copyNumber + ";", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        int copyNumber1 = int.Parse(dr["copyNumber"].ToString());
                        int bookNumber = int.Parse(dr["bookNumber"].ToString());
                        int sequenceNumber = int.Parse(dr["sequenceNumber"].ToString());

                        char type = dr["type"].ToString()[0];
                        int price = int.Parse(dr["price"].ToString());
                        Copy c = new Copy(bookNumber, copyNumber1, sequenceNumber, type, price);
                        con.Close();
                        return c;
                    }

                }
            }
            return null;
        }
        public static Reservation GetFirst(int bookNumber)
        {
            using (SqlConnection con = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("select  top(1)* from Reservation where bookNumber=" + bookNumber + ";", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        int ID = int.Parse(dr["ID"].ToString());
                        int borrowerNumber = int.Parse(dr["borrowerNumber"].ToString());
                        int bookNumber1 = int.Parse(dr["bookNumber"].ToString());
                        DateTime date = Convert.ToDateTime(dr["date"].ToString());
                        char status = dr["status"].ToString()[0];
                    }
                }
            }
            return null;
        }
    }
}
