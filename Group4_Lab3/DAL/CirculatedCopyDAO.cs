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
    class CirculatedCopyDAO
    {
        public static bool Update(CirculatedCopy cc)
        {
            SqlCommand cmd = new SqlCommand("update CirculatedCopy set returnedDate=@returnedDate, fineAmount = @fineAmount where ID=@ID");
            cmd.Parameters.AddWithValue("@returnedDate", cc.ReturnedDate);
            cmd.Parameters.AddWithValue("@fineAmount", cc.FineAmount);
            cmd.Parameters.AddWithValue("@ID", cc.Id);
            return DAO.UpdateTable(cmd);
        }

        public static DataTable GetBorrowedCopies(int borrowerNumber)
        {
            string cmd = "select * from CirculatedCopy where borrowerNumber = " + borrowerNumber + " and returnedDate is null;";
            return DAO.GetDataTable(cmd);
        }

        public static bool Insert(CirculatedCopy cc)
        {
            SqlCommand cmd = new SqlCommand("insert into CirculatedCopy(copyNumber, borrowerNumber, borrowedDate, dueDate, returnedDate, fineAmount)" +
                    "values (@copyNumber, @borrowerNumber, @borrowedDate, @dueDate, null, null)");
            cmd.Parameters.AddWithValue("@copyNumber", cc.CopyNumber);
            cmd.Parameters.AddWithValue("@borrowerNumber", cc.BorrowerNumber);
            cmd.Parameters.AddWithValue("@borrowedDate", cc.BorrowedDate);
            cmd.Parameters.AddWithValue("@dueDate", cc.DueDate);
            return DAO.UpdateTable(cmd);
        }
    }
}
