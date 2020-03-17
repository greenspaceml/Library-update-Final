namespace Group5_Lab3.GUI
{
    partial class ReserveGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckMember = new System.Windows.Forms.Button();
            this.txtBookNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckCondition = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnReserve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Code:";
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.Location = new System.Drawing.Point(113, 36);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(100, 20);
            this.txtMemberCode.TabIndex = 1;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(272, 36);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(100, 20);
            this.txtMemberName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // btnCheckMember
            // 
            this.btnCheckMember.Location = new System.Drawing.Point(396, 34);
            this.btnCheckMember.Name = "btnCheckMember";
            this.btnCheckMember.Size = new System.Drawing.Size(97, 23);
            this.btnCheckMember.TabIndex = 4;
            this.btnCheckMember.Text = "Check member";
            this.btnCheckMember.UseVisualStyleBackColor = true;
            this.btnCheckMember.Click += new System.EventHandler(this.btnCheckMember_Click);
            // 
            // txtBookNumber
            // 
            this.txtBookNumber.Enabled = false;
            this.txtBookNumber.Location = new System.Drawing.Point(113, 73);
            this.txtBookNumber.Name = "txtBookNumber";
            this.txtBookNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBookNumber.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book number:";
            // 
            // btnCheckCondition
            // 
            this.btnCheckCondition.Enabled = false;
            this.btnCheckCondition.Location = new System.Drawing.Point(396, 71);
            this.btnCheckCondition.Name = "btnCheckCondition";
            this.btnCheckCondition.Size = new System.Drawing.Size(158, 23);
            this.btnCheckCondition.TabIndex = 7;
            this.btnCheckCondition.Text = "Check reservation condition";
            this.btnCheckCondition.UseVisualStyleBackColor = true;
            this.btnCheckCondition.Click += new System.EventHandler(this.btnCheckCondition_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(31, 132);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(133, 13);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "Number of reserved book: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 140);
            this.dataGridView1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(272, 311);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(118, 20);
            this.txtDate.TabIndex = 11;
            // 
            // btnReserve
            // 
            this.btnReserve.Enabled = false;
            this.btnReserve.Location = new System.Drawing.Point(486, 309);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(146, 23);
            this.btnReserve.TabIndex = 12;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // ReserveGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 377);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.btnCheckCondition);
            this.Controls.Add(this.txtBookNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheckMember);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemberCode);
            this.Controls.Add(this.label1);
            this.Name = "ReserveGUI";
            this.Load += new System.EventHandler(this.MemberGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckMember;
        private System.Windows.Forms.TextBox txtBookNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckCondition;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnReserve;
    }
}