using System;
using System.Windows.Forms;

namespace CSharp_68PM1_NguyenXuanThanh_0024568
{
    public partial class Form_Login : Form
    {
        private const string CorrectEmail = "nguyenxuanthanh09122005@gmail.com";
        private const string CorrectMSSV = "0024568";

        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text.Trim();
            string mssv = txtPassword.Text.Trim();

            if (email == CorrectEmail && mssv == CorrectMSSV)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form_Main formMain = new Form_Main();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}