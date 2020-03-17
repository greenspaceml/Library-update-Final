using Group5_Lab3.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5_Lab3 {
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
            AboutGUI aboutGUI = new AboutGUI();
            embed(toolStripContainer1.ContentPanel, aboutGUI);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutGUI aboutGUI = new AboutGUI();
            embed(toolStripContainer1.ContentPanel, aboutGUI);
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookGUI bookGUI = new BookGUI();
            embed(toolStripContainer1.ContentPanel, bookGUI);
        }

        

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberGUI memberGUI = new MemberGUI();
            embed(toolStripContainer1.ContentPanel, memberGUI);
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowGUI borrowGUI = new BorrowGUI();
            embed(toolStripContainer1.ContentPanel, borrowGUI);
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnGUI returnGUI = new ReturnGUI();
            embed(toolStripContainer1.ContentPanel, returnGUI);
        }

        private void reserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReserveGUI reserveGUI = new ReserveGUI();
            embed(toolStripContainer1.ContentPanel, reserveGUI);
        }

        private void embed(Panel panel, Form f)
        {
            panel.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Show();

            panel.Controls.Add(f);

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
