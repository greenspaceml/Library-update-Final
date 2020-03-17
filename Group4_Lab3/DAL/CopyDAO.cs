using Group5_Lab3.DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group5_Lab3.DAL
{
    class CopyDAO
    {
        public static DataTable GetCopyTableByBook(int bookNumber)
        {
            string cmd = "SELECT * FROM [Copy] \n" +
                        "WHERE bookNumber = " + bookNumber;
            return DAO.GetDataTable(cmd);
        }

        public static DataTable GetCopyBorrowedTableByBook(int bookNumber)
        {
            String cmd = "SELECT        CirculatedCopy.ID, CirculatedCopy.copyNumber, CirculatedCopy.returnedDate\n" +
                         "FROM            CirculatedCopy INNER JOIN\n" +
                         "                         Copy ON CirculatedCopy.copyNumber = Copy.copyNumber\n" +
                         "WHERE CirculatedCopy.returnedDate IS NULL AND [Copy].bookNumber = " + bookNumber;
            return DAO.GetDataTable(cmd);
        }

        public static DataTable GetDataTable()
        {
            string cmd = "select * from Copy";
            return DAO.GetDataTable(cmd);
        }

        public static int GetCopyNumberMax()
        {
            DataTable dt = GetDataTable();
            if (dt.Rows.Count == 0) return 0;
            else return (int)(dt.Compute("max(CopyNumber)", ""));
        }

        public static int GetSequenceNumberMax(int bookNumber)
        {
            string cmd = "select max(sequenceNumber) from Copy where bookNumber = " + bookNumber + ";";
            return DAO.GetInt(cmd);
        }

        public static bool Insert(Copy c)
        {
            SqlCommand cmd = new SqlCommand("insert into Copy(copyNumber, bookNumber, sequenceNumber, type, price)" +
                    "values (@copyNumber, @bookNumber, @sequenceNumber, @type, @price)");
            cmd.Parameters.AddWithValue("@copyNumber", c.CopyNumber);
            cmd.Parameters.AddWithValue("@bookNumber", c.BookNumber);
            cmd.Parameters.AddWithValue("@sequenceNumber", c.SequenceNumber);
            cmd.Parameters.AddWithValue("@type", c.Type);
            cmd.Parameters.AddWithValue("@price", c.Price);
            return DAO.UpdateTable(cmd);
        }

        public static bool Update(Copy c)
        {
            SqlCommand cmd = new SqlCommand("update Copy set type=@type, price = @price where copyNumber = @copyNumber");
            cmd.Parameters.AddWithValue("@type", c.Type);
            cmd.Parameters.AddWithValue("@price", c.Price);
            cmd.Parameters.AddWithValue("@copyNumber", c.CopyNumber);
            return DAO.UpdateTable(cmd);
        }

        public static Boolean Delete(int copyNumber)
        {
            SqlCommand cmd = new SqlCommand("delete Copy where copyNumber=@copyNumber");
            cmd.Parameters.AddWithValue("@copyNumber", copyNumber);
            return DAO.UpdateTable(cmd);
        }

        public static Copy GetCopy(int CopyNumber)
        {
            return DAO.GetCopyNumber(CopyNumber);
        }
    }
}
