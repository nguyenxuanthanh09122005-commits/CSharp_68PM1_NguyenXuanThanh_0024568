using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_68PM1_NguyenXuanThanh_0024568
{
    public partial class Form_Main : Form
    {

        UserControlQLSV ucSV;
        UserControlQLLH ucLop;

        public Form_Main()
        {
            InitializeComponent();

            ucSV = new UserControlQLSV();
            ucLop = new UserControlQLLH();

            ucLop.OnShowStudents += (className) =>
            {
                ucSV.LoadByClass(className);
                ShowContent(ucSV);
            };

            quảnLýSinhViênToolStripMenuItem.Click += quảnLýSinhViênToolStripMenuItem_Click;
            quảnLýLớpHọcToolStripMenuItem.Click += quảnLýLớpHọcToolStripMenuItem_Click;
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;

            this.FormClosed += (s, e) => Application.Exit();
        }

        private void ShowContent(UserControl uc)
        {

            pnlQLSV.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            pnlQLSV.Controls.Add(uc);
            uc.BringToFront();
            uc.Show();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowContent(ucSV);
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowContent(ucLop);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}