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
    public partial class UserControlQLSV : UserControl
    {
        BindingList<Sinhvien> sinhviens = new BindingList<Sinhvien>();

        public UserControlQLSV()
        {
            InitializeComponent();
            TableSV.AutoGenerateColumns = false;
            TableSV.DataSource = sinhviens;

            // Ánh xạ các cột nếu cần (Dựa trên tên thuộc tính của lớp Sinhvien)
            TableSV.Columns[0].DataPropertyName = "MaSV";
            TableSV.Columns[1].DataPropertyName = "HoTen";
            TableSV.Columns[2].DataPropertyName = "GioiTinh";
            TableSV.Columns[3].DataPropertyName = "NgaySinh";
            TableSV.Columns[4].DataPropertyName = "Lop";

            // Đăng ký sự kiện
            Insert.Click += Insert_Click;
            Update.Click += Update_Click;
            Delete.Click += Delete_Click;
            Reset.Click += Reset_Click;
            TableSV.CellClick += TableSV_CellClick;
            btn_search.Click += btn_search_Click;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                TableSV.DataSource = sinhviens;
            }
            else
            {
                var filtered = sinhviens.Where(s =>
                    (s.MaSV != null && s.MaSV.ToLower().Contains(keyword)) ||
                    (s.HoTen != null && s.HoTen.ToLower().Contains(keyword)) ||
                    (s.Lop != null && s.Lop.ToLower().Contains(keyword))
                ).ToList();
                TableSV.DataSource = new BindingList<Sinhvien>(filtered);
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien()
            {
                MaSV = mssv_i.Text.Trim(),
                HoTen = name_i.Text.Trim(),
                NgaySinh = birthday_i.Value.ToString("dd/MM/yyyy"),
                GioiTinh = genre_i.Text.Trim(),
                Lop = class_i.Text.Trim(),
            };
            sinhviens.Add(sv);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }

        private void ResetForm()
        {
            mssv_i.Clear();
            name_i.Clear();
            birthday_i.Value = DateTime.Now;
            genre_i.SelectedIndex = -1;
            class_i.SelectedIndex = -1;
        }

        private void UpdateForm(string mssv, string name, string birthday, string genre, string classN)
        {
            mssv_i.Text = mssv;
            name_i.Text = name;
            try
            {
                birthday_i.Value = DateTime.ParseExact(birthday, "dd/MM/yyyy", null);
            }
            catch
            {
                birthday_i.Value = DateTime.Now;
            }
            genre_i.Text = genre;
            class_i.Text = classN;
        }

        private void TableSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Sinhvien sv = (Sinhvien)TableSV.Rows[e.RowIndex].DataBoundItem;
                if (sv != null)
                {
                    UpdateForm(sv.MaSV, sv.HoTen, sv.NgaySinh, sv.GioiTinh, sv.Lop);
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (TableSV.CurrentRow != null)
            {
                Sinhvien updateSV = (Sinhvien)TableSV.CurrentRow.DataBoundItem;
                updateSV.MaSV = mssv_i.Text.Trim();
                updateSV.HoTen = name_i.Text.Trim();
                updateSV.NgaySinh = birthday_i.Value.ToString("dd/MM/yyyy");
                updateSV.GioiTinh = genre_i.Text;
                updateSV.Lop = class_i.Text;
                sinhviens.ResetBindings();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (TableSV.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                   "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Sinhvien deleteSV = (Sinhvien)TableSV.CurrentRow.DataBoundItem;
                    sinhviens.Remove(deleteSV);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UserControlQLSV_Load(object sender, EventArgs e)
        {

        }
    }
}
