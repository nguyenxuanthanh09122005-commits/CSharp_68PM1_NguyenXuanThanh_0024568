using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CSharp_68PM1_NguyenXuanThanh_0024568
{
    public partial class UserControlQLLH : UserControl
    {
        public delegate void ShowStudentsEventHandler(string className);
        public event ShowStudentsEventHandler OnShowStudents;

        CSharp_68PM1_NguyenXuanThanh_0024568.Database.Database db = new CSharp_68PM1_NguyenXuanThanh_0024568.Database.Database();
        int currentPage = 1;
        int pageSize = 5;
        int totalRecords = 0;
        int totalPages = 1;

        public UserControlQLLH()
        {
            InitializeComponent();
            TableLop.AutoGenerateColumns = false;

            TableLop.Columns[0].DataPropertyName = "MaID";
            TableLop.Columns[1].DataPropertyName = "MaLop";
            TableLop.Columns[2].DataPropertyName = "TenLop";
            TableLop.Columns[3].DataPropertyName = "GhiChu";

            btn_add.Click += btn_add_Click;
            btn_Update.Click += btn_Update_Click;
            btn_delete.Click += btn_delete_Click;
            btn_reset.Click += btn_reset_Click;
            btn_search.Click += btn_search_Click;
            TableLop.CellClick += TableLop_CellClick;
            btn_showSV.Click += btn_showSV_Click;

            btn_first.Click += (s, e) => { currentPage = 1; LoadData(); };
            btn_prev.Click += (s, e) => { if (currentPage > 1) { currentPage--; LoadData(); } };
            btn_next.Click += (s, e) => { if (currentPage < totalPages) { currentPage++; LoadData(); } };
            btn_last.Click += (s, e) => { currentPage = totalPages; LoadData(); };
        }

        private void btn_showSV_Click(object sender, EventArgs e)
        {
            if (TableLop.CurrentRow != null)
            {
                string className = TableLop.CurrentRow.Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(className))
                {
                    OnShowStudents?.Invoke(className);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lớp!");
            }
        }

        private void LoadData()
        {
            try
            {
                string countSql = "SELECT COUNT(*) FROM lop";
                string filter = "";
                MySqlParameter[] pars = null;

                if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                {
                    filter = " WHERE MaLop LIKE @k OR TenLop LIKE @k OR GhiChu LIKE @k";
                    countSql += filter;
                    pars = new MySqlParameter[] { new MySqlParameter("@k", "%" + txtSearch.Text.Trim() + "%") };
                }

                totalRecords = Convert.ToInt32(db.GetValue(countSql, pars));
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                if (totalPages == 0) totalPages = 1;
                if (currentPage > totalPages) currentPage = totalPages;
                if (currentPage < 1) currentPage = 1;

                int offset = (currentPage - 1) * pageSize;
                string sql = "SELECT * FROM lop" + filter + $" LIMIT {offset}, {pageSize}";

                MySqlParameter[] queryPars = null;
                if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                {
                    queryPars = new MySqlParameter[] { new MySqlParameter("@k", "%" + txtSearch.Text.Trim() + "%") };
                }

                TableLop.DataSource = db.GetTable(sql, queryPars);

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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmaClass.Text) || string.IsNullOrEmpty(txtnameClass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã lớp và Tên lớp!");
                return;
            }

            try
            {
                string sql = "INSERT INTO lop (MaLop, TenLop, GhiChu) VALUES (@ma, @ten, @note)";
                MySqlParameter[] pars = {
                    new MySqlParameter("@ma", txtmaClass.Text.Trim()),
                    new MySqlParameter("@ten", txtnameClass.Text.Trim()),
                    new MySqlParameter("@note", textBox3.Text.Trim())
                };
                db.Execute(sql, pars);
                MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (TableLop.CurrentRow == null) return;

            try
            {
                string maID = TableLop.CurrentRow.Cells[0].Value.ToString();
                string sql = "UPDATE lop SET MaLop=@ma, TenLop=@ten, GhiChu=@note WHERE MaID=@id";
                MySqlParameter[] pars = {
                    new MySqlParameter("@ma", txtmaClass.Text.Trim()),
                    new MySqlParameter("@ten", txtnameClass.Text.Trim()),
                    new MySqlParameter("@note", textBox3.Text.Trim()),
                    new MySqlParameter("@id", maID)
                };
                db.Execute(sql, pars);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (TableLop.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này không?",
                   "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string maID = TableLop.CurrentRow.Cells[0].Value.ToString();
                        string sql = "DELETE FROM lop WHERE MaID = @id";
                        MySqlParameter[] pars = { new MySqlParameter("@id", maID) };
                        db.Execute(sql, pars);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ResetForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa: " + ex.Message);
                    }
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetForm();
            txtSearch.Clear();
            currentPage = 1;
            LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData();
        }

        private void TableLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = TableLop.Rows[e.RowIndex];
                txtmaClass.Text = row.Cells[1].Value?.ToString();
                txtnameClass.Text = row.Cells[2].Value?.ToString();
                textBox3.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void ResetForm()
        {
            txtmaClass.Clear();
            txtnameClass.Clear();
            textBox3.Clear();
        }

        private void UserControlQLLH_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}