using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CSharp_68PM1_NguyenXuanThanh_0024568
{
    public partial class UserControlQLSV : UserControl
    {

        CSharp_68PM1_NguyenXuanThanh_0024568.Database.Database db = new CSharp_68PM1_NguyenXuanThanh_0024568.Database.Database();
        int currentPage = 1;
        int pageSize = 5;
        int totalRecords = 0;
        int totalPages = 1;

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

            btn_first.Click += (s, e) => { currentPage = 1; LoadData(); };
            btn_prev.Click += (s, e) => { if (currentPage > 1) { currentPage--; LoadData(); } };
            btn_next.Click += (s, e) => { if (currentPage < totalPages) { currentPage++; LoadData(); } };
            btn_last.Click += (s, e) => { currentPage = totalPages; LoadData(); };

            this.Load += UserControlQLSV_Load;
        }

        private void LoadClasses()
        {
            try
            {
                string sql = "SELECT MaLop, TenLop FROM lophoc";
                System.Data.DataTable dt = db.GetTable(sql);
                class_i.Items.Clear();
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    class_i.Items.Add($"{row["MaLop"]} - {row["TenLop"]}");
                }
            }
            catch (Exception ex)
            {
                // Silent fail or log
            }
        }

        private void LoadData()
        {
            try
            {
                string countSql = "SELECT COUNT(*) FROM sinhvien";
                string filter = "";
                MySqlParameter[] pars = null;

                if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
                {
                    filter = " WHERE MaSV LIKE @k OR HoTen LIKE @k OR Lop LIKE @k";
                    countSql += filter;
                    pars = new MySqlParameter[] { new MySqlParameter("@k", "%" + textBox1.Text.Trim() + "%") };
                }

                totalRecords = Convert.ToInt32(db.GetValue(countSql, pars));
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                if (totalPages == 0) totalPages = 1;
                if (currentPage > totalPages) currentPage = totalPages;
                if (currentPage < 1) currentPage = 1;

                int offset = (currentPage - 1) * pageSize;
                string sql = "SELECT * FROM sinhvien" + filter + $" LIMIT {offset}, {pageSize}";
                
                // Reuse parameters for the main query
                MySqlParameter[] queryPars = null;
                if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
                {
                    queryPars = new MySqlParameter[] { new MySqlParameter("@k", "%" + textBox1.Text.Trim() + "%") };
                }

                TableSV.DataSource = db.GetTable(sql, queryPars);

                lbl_pageinfo.Text = $"Trang {currentPage}/{totalPages} | {totalRecords} bản ghi";
                UpdatePaginationButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void UpdatePaginationButtons()
        {
            btn_first.Enabled = currentPage > 1;
            btn_prev.Enabled = currentPage > 1;
            btn_next.Enabled = currentPage < totalPages;
            btn_last.Enabled = currentPage < totalPages;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData();
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
        //Chức năng Xóa sinh viên 
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
            LoadClasses();
            LoadData();
        }

        private void TableSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}