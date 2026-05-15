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
   
    public partial class Form2 : Form
    {  
        
        BindingList<Sinhvien> sinhviens = new BindingList<Sinhvien>();
        public Form2()
        {
            InitializeComponent();
            TableSV.Columns.Clear();
            TableSV.DataSource = sinhviens;
            TableSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (TableSV.Columns.Count >= 5)
            {
                TableSV.Columns[0].HeaderText = "Mã SV";
                TableSV.Columns[1].HeaderText = "Họ và Tên";
                TableSV.Columns[2].HeaderText = "Ngày sinh";
                TableSV.Columns[3].HeaderText = "Giới tính";
                TableSV.Columns[4].HeaderText = "Lớp";
            }

            // Đăng ký sự kiện trực tiếp bằng code
            Insert.Click -= Insert_Click; // Gỡ ra trước để tránh bị lặp nếu đã có
            Insert.Click += Insert_Click;

            Update.Click -= Update_Click;
            Update.Click += Update_Click;

            Delete.Click -= Delete_Click;
            Delete.Click += Delete_Click;

            Reset.Click -= Reset_Click;
            Reset.Click += Reset_Click;

            TableSV.CellClick -= TableSV_CellClick;
            TableSV.CellClick += TableSV_CellClick;

            btn_search.Click -= btn_search_Click;
            btn_search.Click += btn_search_Click;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu trống thì hiện lại toàn bộ danh sách gốc
                TableSV.DataSource = sinhviens;
            }
            else
            {
                // Lọc danh sách: Tìm trong Mã SV, Họ Tên hoặc Lớp có chứa từ khóa không
                var filtered = sinhviens.Where(s =>
                    (s.MaSV != null && s.MaSV.ToLower().Contains(keyword)) ||
                    (s.HoTen != null && s.HoTen.ToLower().Contains(keyword)) ||
                    (s.Lop != null && s.Lop.ToLower().Contains(keyword))
                ).ToList();

                // Hiển thị danh sách đã lọc lên bảng
                TableSV.DataSource = new BindingList<Sinhvien>(filtered);
            }
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            birthday_i.Value=DateTime.Now;
            genre_i.SelectedIndex=-1;
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
                // Nếu lỗi định dạng ngày, gán ngày hiện tại để không treo máy
                birthday_i.Value = DateTime.Now;
            }
            genre_i.Text = genre;
            class_i.Text = classN;
        }

        private void TableSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    Sinhvien sv = (Sinhvien)TableSV.Rows[e.RowIndex].DataBoundItem;
                    if (sv != null)
                    {
                        UpdateForm(sv.MaSV, sv.HoTen, sv.NgaySinh, sv.GioiTinh, sv.Lop);
                    }
                }
                catch (Exception ex)
                {
                    // Chỉ thông báo nếu thực sự cần thiết, hoặc bỏ qua để tránh phiền người dùng
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
                         updateSV.NgaySinh = birthday_i.Text.Trim();
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
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
               "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                Sinhvien deleteSV = (Sinhvien)TableSV.CurrentRow.DataBoundItem;
                sinhviens.Remove(deleteSV);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
       

    


