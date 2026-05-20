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
        // Khai báo sẵn các UserControl làm biến toàn cục để dùng chung
        UserControlQLSV ucSV;
        UserControlQLLH ucLop;

        public Form_Main()
        {
            InitializeComponent();
            
            // Khởi tạo các UserControl
            ucSV = new UserControlQLSV();
            ucLop = new UserControlQLLH();

            // Đăng ký sự kiện Click (Đảm bảo các sự kiện này được nối với hàm xử lý)
            quảnLýSinhViênToolStripMenuItem.Click += quảnLýSinhViênToolStripMenuItem_Click;
            quảnLýLớpHọcToolStripMenuItem.Click += quảnLýLớpHọcToolStripMenuItem_Click;
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
        }

        private void ShowContent(UserControl uc)
        {
            // Xóa nội dung cũ trong panel
            pnlQLSV.Controls.Clear();
            
            // Thiết lập thuộc tính cho UserControl mới
            uc.Dock = DockStyle.Fill;
            
            // Thêm vào panel và đưa lên trên cùng
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
