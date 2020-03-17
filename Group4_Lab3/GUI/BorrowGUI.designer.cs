namespace Group5_Lab3.GUI
{
    partial class BorrowGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberBorrowedBooks = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnCondition = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.txtBorrowerNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCopyNumber = new System.Windows.Forms.TextBox();
            this.txtBorrowedDate = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(504, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "The number of borrowed books:";
            // 
            // lblNumberBorrowedBooks
            // 
            this.lblNumberBorrowedBooks.AutoSize = true;
            this.lblNumberBorrowedBooks.Location = new System.Drawing.Point(461, 24);
            this.lblNumberBorrowedBooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberBorrowedBooks.Name = "lblNumberBorrowedBooks";
            this.lblNumberBorrowedBooks.Size = new System.Drawing.Size(13, 13);
            this.lblNumberBorrowedBooks.TabIndex = 2;
            this.lblNumberBorrowedBooks.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Member code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Copy number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Borrowed date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 372);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Due date:";
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(84, 162);
            this.btnMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(163, 24);
            this.btnMember.TabIndex = 8;
            this.btnMember.Text = "Check Member";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnCondition
            // 
            this.btnCondition.Location = new System.Drawing.Point(294, 286);
            this.btnCondition.Margin = new System.Windows.Forms.Padding(2);
            this.btnCondition.Name = "btnCondition";
            this.btnCondition.Size = new System.Drawing.Size(154, 24);
            this.btnCondition.TabIndex = 9;
            this.btnCondition.Text = "Check borrow condition";
            this.btnCondition.UseVisualStyleBackColor = true;
            this.btnCondition.Click += new System.EventHandler(this.btnCondition_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(296, 362);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(154, 24);
            this.btnBorrow.TabIndex = 10;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // txtBorrowerNumber
            // 
            this.txtBorrowerNumber.Location = new System.Drawing.Point(110, 76);
            this.txtBorrowerNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtBorrowerNumber.Name = "txtBorrowerNumber";
            this.txtBorrowerNumber.Size = new System.Drawing.Size(138, 20);
            this.txtBorrowerNumber.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 115);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 12;
            // 
            // txtCopyNumber
            // 
            this.txtCopyNumber.Location = new System.Drawing.Point(110, 292);
            this.txtCopyNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCopyNumber.Name = "txtCopyNumber";
            this.txtCopyNumber.Size = new System.Drawing.Size(138, 20);
            this.txtCopyNumber.TabIndex = 13;
            // 
            // txtBorrowedDate
            // 
            this.txtBorrowedDate.Location = new System.Drawing.Point(110, 332);
            this.txtBorrowedDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBorrowedDate.Name = "txtBorrowedDate";
            this.txtBorrowedDate.Size = new System.Drawing.Size(138, 20);
            this.txtBorrowedDate.TabIndex = 14;
            this.txtBorrowedDate.Click += new System.EventHandler(this.txtBorrowedDate_Validated);
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(110, 370);
            this.txtDueDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(138, 20);
            this.txtDueDate.TabIndex = 15;
            // 
            // BorrowGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 402);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.txtBorrowedDate);
            this.Controls.Add(this.txtCopyNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBorrowerNumber);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnCondition);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumberBorrowedBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BorrowGUI";
            this.Text = "BorrowGUI";
            this.Click += new System.EventHandler(this.txtBorrowedDate_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberBorrowedBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnCondition;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.TextBox txtBorrowerNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCopyNumber;
        private System.Windows.Forms.TextBox txtBorrowedDate;
        private System.Windows.Forms.TextBox txtDueDate;
    }
}