using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group5_Lab3.DTL;

namespace Group5_Lab3.DAL
{
    class ReserveDAO
    {
        public static DataTable GetReservedTableByBorrower(int borrowerNumber)
        {
            string cmd = "SELECT * FROM [Reservation] \n" +
                        "WHERE borrowerNumber = " + borrowerNumber + " AND status LIKE 'R'";
            return DAO.GetDataTable(cmd);
        }



        public static bool Insert(Reservation r)
        {
            SqlCommand cmd = new SqlCommand("insert into [Reservation]([borrowerNumber], [bookNumber], [date], [status])" +
                    "values (@borrowerNumber, @bookNumber, @date, @status)");
            cmd.Parameters.AddWithValue("@borrowerNumber", r.BorrowerNumber);
            cmd.Parameters.AddWithValue("@bookNumber", r.BookNumber);
            cmd.Parameters.AddWithValue("@date", r.Date);
            cmd.Parameters.AddWithValue("@status", r.Status);

            return DAO.UpdateTable(cmd);
        }

        public static bool Update(Reservation r)
        {
            SqlCommand cmd = new SqlCommand("update Reservation set borrowerNumber=@borrowerNumber, bookNumber = @bookNumber, date = @date, status = @status where ID=@ID");
            cmd.Parameters.AddWithValue("@borrowerNumber", r.BorrowerNumber);
            cmd.Parameters.AddWithValue("@bookNumber", r.BookNumber);
            cmd.Parameters.AddWithValue("@date", r.Date);
            cmd.Parameters.AddWithValue("@status", r.Status);
            return DAO.UpdateTable(cmd);
        }

        public static Reservation GetFirstReservation(int bookNumber)
        {
            return DAO.GetFirst(bookNumber);
        }
    }
}
