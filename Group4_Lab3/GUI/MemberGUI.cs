using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group5_Lab3.DAL;
using Group5_Lab3.DTL;
using Group5_Lab3.GUI;

namespace Group5_Lab3.GUI
{
    public partial class MemberGUI : Form
    {
        DataView dv, dvc;
        Borrower b;
        public MemberGUI()
        {
            InitializeComponent();
            View();
            displayButtons(1);
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            int memberCode;
            try
            {
                memberCode = int.Parse(textBoxMember.Text);
            }
            catch
            {
                MessageBox.Show("Member number must be integer (empty for all members)!");
                if (textBoxMember.Text != "") return;
                else memberCode = -1;
            }

            if (memberCode > -1) dv.RowFilter = "borrowerNumber = " + memberCode.ToString();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "Add")
            {
                b = new Borrower(BorrowerDAO.GetBorrowerNumberMax() + 1, "", ' ', "","","");
                displayMember();

                displayButtons(2);
            }
            else
            {

                b.Name = textBoxName.Text;
                b.Sex = char.Parse( textBoxSex.Text);
                b.Telephone = textBoxTele.Text;
                b.Email = textBoxEmail.Text;
                b.Address = textBoxAddress.Text;


                BorrowerDAO.Insert(b);

                // Add to DataTable
                DataTable dt = dv.Table;
                DataRow newRow = dt.NewRow();
                newRow["borrowerNumber"] = b.BorrowerNumber;
                newRow["name"] = b.Name;
                newRow["sex"] = b.Sex;
                newRow["address"] = b.Address;
                newRow["telephone"] = b.Telephone;
                newRow["email"] = b.Email;
                dt.Rows.Add(newRow);
                dv.RowFilter = "";

                displayButtons(1);
            }
        }
        private void displayButtons(int state)
        {
            switch (state)
            {
                // allow to filter/Add/Edit/Delete borrower
                case 1:
                    textBoxMember.Enabled = true;
                    textBoxMember.Focus();

                    textBoxName.Enabled = false;
                    textBoxSex.Enabled = false;
                    textBoxTele.Enabled = false;
                    textBoxAddress.Enabled = false;
                    textBoxEmail.Enabled = false;
                    btnFilter.Enabled = true;

                    btnAdd.Text = "Add";
                    btnAdd.Enabled = true;

                    btnEdit.Text = "Edit";
                    btnEdit.Enabled = true;

                    btnDelete.Enabled = true;
                    break;

                // Allow to add a borrowes
                case 2:
                    textBoxMember.Enabled = false;
                    textBoxName.Enabled = true;
                    textBoxSex.Enabled = true;
                    textBoxTele.Enabled = true;
                    textBoxAddress.Enabled = true;
                    textBoxEmail.Enabled = true;
                    textBoxName.Focus();

                    btnAdd.Text = "Save";
                    btnAdd.Enabled = true;

                    btnFilter.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;

                    break;

                // Allow to edit a borrower
                case 3:
                    textBoxMember.Enabled = false;
                    textBoxName.Enabled = true;
                    textBoxSex.Enabled = true; textBoxTele.Enabled = true;

                    textBoxAddress.Enabled = true;
                    textBoxEmail.Enabled = true;
                    textBoxName.Focus();

                    btnEdit.Text = "Save";
                    btnEdit.Enabled = true;

                    btnFilter.Enabled = false;
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    break;

            }
        }

        private void RegisterGUI_Load(object sender, EventArgs e)
        {

        }

        // get members and display
        private void View()
        {
            DataTable dt = BorrowerDAO.GetDataTable();
            dv = new DataView(dt);
            dataGridView1.DataSource = dv;
        }
      
        private void displayMember()
        {
            textBoxMember.Text = b.BorrowerNumber.ToString();
            textBoxName.Text = b.Name;
            textBoxSex.Text = b.Sex.ToString();
            textBoxTele.Text = b.Telephone;
            textBoxEmail.Text = b.Email;
            textBoxAddress.Text = b.Email;

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            textBoxMember.Text = dataGridView1.Rows[e.RowIndex].Cells["borrowerNumber"].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            textBoxSex.Text = dataGridView1.Rows[e.RowIndex].Cells["sex"].Value.ToString();
            textBoxTele.Text = dataGridView1.Rows[e.RowIndex].Cells["telephone"].Value.ToString();
            textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
            textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "Edit")
            {
                if (!isSelected()) return;

                textBoxMember.Text = dataGridView1.SelectedRows[0].Cells["borrowerNumber"].Value.ToString();

                textBoxName.Text = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
                textBoxSex.Text = dataGridView1.SelectedRows[0].Cells["sex"].Value.ToString();
                textBoxEmail.Text = dataGridView1.SelectedRows[0].Cells["email"].Value.ToString();
                textBoxAddress.Text = dataGridView1.SelectedRows[0].Cells["address"].Value.ToString();
                textBoxTele.Text = dataGridView1.SelectedRows[0].Cells["telephone"].Value.ToString();



                displayButtons(3);

            }
            else
            {
                b = new Borrower(int.Parse(textBoxMember.Text), textBoxName.Text, char.Parse(textBoxSex.Text),
                    textBoxAddress.Text, textBoxTele.Text, textBoxEmail.Text);
                BorrowerDAO.Update(b);

                // Update in DataTable
                DataTable dt = dv.Table;
                DataRow[] result = dt.Select("borrowerNumber = " + b.BorrowerNumber);
                DataRow row = result[0];
                row["name"] = b.Name;
                row["sex"] = b.Sex;
                row["address"] = b.Address;
                row["telephone"] = b.Telephone;
                row["email"] = b.Email;
                dv.RowFilter = "";

                displayButtons(1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isSelected()) return;

            int borrowerNumber = (int)dataGridView1.SelectedRows[0].Cells["borrowerNumber"].Value;
            DialogResult dr = MessageBox.Show(String.Format("Do you want to delete member number {0}?", borrowerNumber), "Confirm deteting", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;

            BorrowerDAO.Delete(borrowerNumber);

            // Delete in DataTable
            DataTable dt = dv.Table;
            DataRow[] result = dt.Select("borrowerNumber = " + borrowerNumber);
            result[0].Delete();


        }

        private void textBoxMember_TextChanged(object sender, EventArgs e)
        {

        }

        private bool isSelected()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must select a row in the list of members!");
                return false;
            }
            if (dataGridView1.SelectedRows[0].Cells["borrowerNumber"].Value == null)
            {
                MessageBox.Show("You must select a member in the list of members!");
                return false;
            }
            return true;
        }

    }
}
