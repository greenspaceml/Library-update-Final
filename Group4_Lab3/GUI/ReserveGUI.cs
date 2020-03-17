using Group5_Lab3.DAL;
using Group5_Lab3.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5_Lab3.GUI
{
    public partial class ReserveGUI : Form
    {
        public ReserveGUI()
        {
            InitializeComponent();
        }

        private void MemberGUI_Load(object sender, EventArgs e)
        {

        }

        private void SetComponentStatus(int step)
        {
            switch (step)
            {
                case 1:
                    btnCheckCondition.Enabled = false;
                    btnReserve.Enabled = false;
                    txtBookNumber.Enabled = false;
                    txtDate.Enabled = false;
                    break;
                case 2:
                    txtMemberCode.Enabled = false;
                    btnCheckCondition.Enabled = true;
                    txtBookNumber.Enabled = true;
                    break;
                case 3:
                    btnReserve.Enabled = true;
                    txtDate.Enabled = true;
                    break;
            }
        }

        private void View(int borrowerNumber)
        {
            DataTable dataTable = ReserveDAO.GetReservedTableByBorrower(borrowerNumber);
            labelCount.Text = "Number of reserved book: " + dataTable.Rows.Count;
            dataGridView1.DataSource = new DataView(dataTable);
        }

        private int checkCondition(int borrowerNumber, int bookNumber)
        {
            //đã đặt quyển nào chưa?
            DataTable dataTable = ReserveDAO.GetReservedTableByBorrower(borrowerNumber);
            int countReservation = dataTable.Rows.Count;
            if(countReservation > 0)
            {
                return -1;
            }

            //Sách ý có bản Copy nào không?
            DataTable copyTable = CopyDAO.GetCopyTableByBook(bookNumber);
            int countCopy = copyTable.Rows.Count;
            if (countCopy == 0)
            {
                return -2;
            }

            //Tất cả bản Copy đã bị mượn hết chưa
            DataTable copyBorrowedTable = CopyDAO.GetCopyBorrowedTableByBook(bookNumber);
            int countCopyBorrowed = copyBorrowedTable.Rows.Count;
            if (countCopyBorrowed < countCopy)
            {
                return -3;
            }

            return 1;
        }

        private String getConditionMsg(int condition)
        {
            switch (condition)
            {
                case -1:
                    return "Borrower has already reserved a book.";
                case -2:
                    return "This book doesn't have any Copy to borrow.";
                case -3:
                    return "This book has available copy. Please borrow book.";
            }
            return "";
        }

        private void btnCheckMember_Click(object sender, EventArgs e)
        {
            int borrowerNumber;
            try
            {
                borrowerNumber = int.Parse(txtMemberCode.Text);
            }
            catch
            {
                borrowerNumber = 0;
            }
            
            Borrower b = BorrowerDAO.GetBorrower(borrowerNumber);
            if(b == null)
            {
                MessageBox.Show("Borrower not found !");
            }
            else
            {
                txtMemberName.Text = b.Name;
                View(b.BorrowerNumber);
                SetComponentStatus(2);
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            DateTime dateTime;
            try
            {
                dateTime = DateTime.ParseExact(txtDate.Text, "dd/MM/yyyy", null);
            }
            catch
            {
                MessageBox.Show("Format of date is not valid!");
                return;
            }

            int borrowerNumber = int.Parse(txtMemberCode.Text);
            int bookNumber = int.Parse(txtBookNumber.Text);

            Reservation r = new Reservation(borrowerNumber, bookNumber, dateTime);
            ReserveDAO.Insert(r);
            View(borrowerNumber);
            SetComponentStatus(1);
        }

        private void btnCheckCondition_Click(object sender, EventArgs e)
        {
            int borrowerNumber = int.Parse(txtMemberCode.Text);
            int bookNumber;
            try
            {
                bookNumber = int.Parse(txtBookNumber.Text);
            }
            catch
            {
                if(txtBookNumber.Text == "")
                {
                    MessageBox.Show("Book number must NOT empty !");
                }
                return;
            }
            int condition = checkCondition(borrowerNumber, bookNumber);
            if(condition == 1)
            {
                SetComponentStatus(3);
            }
            else
            {
                MessageBox.Show(getConditionMsg(condition));
            }
        }
    }
}
