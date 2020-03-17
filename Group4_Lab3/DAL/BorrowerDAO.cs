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
    class BorrowerDAO
    {
        public static Borrower GetBorrower(int borrowerNumber)
        {
            string cmd = "SELECT * FROM Borrower WHERE borrowerNumber = " + borrowerNumber;
            DataTable data = DAO.GetDataTable(cmd);
            if(data.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = data.Select("borrowerNumber = " + borrowerNumber)[0];
            string name = row["name"].ToString();
            char sex = char.Parse(row["sex"].ToString());

            return new Borrower(borrowerNumber, name, sex, "", "", "");

        }

        public static DataTable GetDataTable()
        {
            string cmd = "select * from Borrower";
            return DAO.GetDataTable(cmd);
        }

        public static int GetBorrowerNumberMax()
        {
            DataTable dt = GetDataTable();
            if (dt.Rows.Count == 0) return 0;
            else return (int)(dt.Compute("max(borrowerNumber)", ""));
        }

        public static bool Insert(Borrower b)
        {
            SqlCommand cmd = new SqlCommand("insert into Borrower(name, sex, address,telephone,email)" +
                    "values (@name, @sex, @address,@telephone,@email)");
            cmd.Parameters.AddWithValue("@name", b.Name);
            cmd.Parameters.AddWithValue("@sex", b.Sex);
            cmd.Parameters.AddWithValue("@telephone", b.Telephone);
            cmd.Parameters.AddWithValue("@address", b.Address);
            cmd.Parameters.AddWithValue("@email", b.Email);

            return DAO.UpdateTable(cmd);
        }

        public static bool Update(Borrower b)
        {
            SqlCommand cmd = new SqlCommand("update Borrower set name=@name, sex = @sex, address = @address, telephone = @telephone, " +
                " email=@email where borrowerNumber = @borrowerNumber");
            cmd.Parameters.AddWithValue("@borrowerNumber", b.BorrowerNumber);

            cmd.Parameters.AddWithValue("@name", b.Name);
            cmd.Parameters.AddWithValue("@sex", b.Sex);
            cmd.Parameters.AddWithValue("@telephone", b.Telephone);
            cmd.Parameters.AddWithValue("@address", b.Address);
            cmd.Parameters.AddWithValue("@email", b.Email);
            return DAO.UpdateTable(cmd);
        }

        public static Boolean Delete(int borrowerNumber)
        {
            SqlCommand cmd = new SqlCommand("delete Borrower where borrowerNumber=@borrowerNumber");
            cmd.Parameters.AddWithValue("@borrowerNumber", borrowerNumber);
            return DAO.UpdateTable(cmd);
        }
    }
}
