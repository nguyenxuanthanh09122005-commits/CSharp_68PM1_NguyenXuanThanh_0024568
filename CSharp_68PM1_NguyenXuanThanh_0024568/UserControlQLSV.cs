using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CSharp_68PM1_NguyenXuanThanh_0024568
{
    public partial class UserControlQLSV : UserControl
    {

        CSharp_68PM1_NguyenXuanThanh_0024568.Database.Database db = new CSharp_68PM1_NguyenXuanThanh_0024568.Database.Database();

        public UserControlQLSV()
        {
            InitializeComponent();
            TableSV.AutoGenerateColumns = false;

            TableSV.Columns[0].DataPropertyName = "MaSV";
            TableSV.Columns[1].DataPropertyName = "HoTen";
            TableSV.Columns[2].DataPropertyName = "GioiTinh";
            TableSV.Columns[3].DataPropertyName = "NgaySinh";
            TableSV.Columns[4].DataPropertyName = "Lop";

            Insert.Click += Insert_Click;
            Delete.Click += Delete_Click;
            Reset.Click += Reset_Click;
            TableSV.CellClick += TableSV_CellClick;
            btn_search.Click += btn_search_Click;

            this.Load += UserControlQLSV_Load;
        }

        private void LoadData()
        {
            try
            {
                TableSV.DataSource = db.GetTable("SELECT * FROM sinhvien");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = "%" + textBox1.Text.Trim() + "%";
                string sql = "SELECT * FROM SinhVien WHERE MaSV LIKE @k OR HoTen LIKE @k OR Lop LIKE @k";
                MySqlParameter[] pars = { new MySqlParameter("@k", keyword) };
                TableSV.DataSource = db.GetTable(sql, pars);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, Lop) VALUES (@ma, @ten, @ns, @gt, @lop)";
                MySqlParameter[] pars = {
                    new MySqlParameter("@ma", mssv_i.Text.Trim()),
                    new MySqlParameter("@ten", name_i.Text.Trim()),
                    new MySqlParameter("@ns", birthday_i.Value.ToString("yyyy-MM-dd")),
                    new MySqlParameter("@gt", genre_i.Text),
                    new MySqlParameter("@lop", class_i.Text)
                };
                db.Execute(sql, pars);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
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
                if (DateTime.TryParse(birthday, out DateTime dt))
                {
                    birthday_i.Value = dt;
                }
                else
                {
                    birthday_i.Value = DateTime.ParseExact(birthday, "dd/MM/yyyy", null);
                }
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
                DataGridViewRow row = TableSV.Rows[e.RowIndex];
                UpdateForm(
                    row.Cells[0].Value?.ToString(),
                    row.Cells[1].Value?.ToString(),
                    row.Cells[3].Value?.ToString(),
                    row.Cells[2].Value?.ToString(),
                    row.Cells[4].Value?.ToString()
                );
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE SinhVien SET HoTen=@ten, NgaySinh=@ns, GioiTinh=@gt, Lop=@lop WHERE MaSV=@ma";
                MySqlParameter[] pars = {
                    new MySqlParameter("@ma", mssv_i.Text.Trim()),
                    new MySqlParameter("@ten", name_i.Text.Trim()),
                    new MySqlParameter("@ns", birthday_i.Value.ToString("yyyy-MM-dd")),
                    new MySqlParameter("@gt", genre_i.Text),
                    new MySqlParameter("@lop", class_i.Text)
                };
                db.Execute(sql, pars);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadData();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (TableSV.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                   "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string maSV = TableSV.CurrentRow.Cells[0].Value.ToString();
                        string sql = "DELETE FROM SinhVien WHERE MaSV = @ma";
                        MySqlParameter[] pars = { new MySqlParameter("@ma", maSV) };
                        db.Execute(sql, pars);
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa: " + ex.Message);
                    }
                }
            }
        }

        private void UserControlQLSV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void TableSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}