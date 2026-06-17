namespace CSharp_68PM1_NguyenXuanThanh_0024568
{
    partial class UserControlQLSV
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.TableSV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.birthday_i = new System.Windows.Forms.DateTimePicker();
            this.class_i = new System.Windows.Forms.ComboBox();
            this.genre_i = new System.Windows.Forms.ComboBox();
            this.name_i = new System.Windows.Forms.TextBox();
            this.mssv_i = new System.Windows.Forms.TextBox();
            this.classn = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.mssv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.lbl_pageinfo = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableSV)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý Sinh viên";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.mssv);
            this.groupBoxInfo.Controls.Add(this.mssv_i);
            this.groupBoxInfo.Controls.Add(this.name);
            this.groupBoxInfo.Controls.Add(this.name_i);
            this.groupBoxInfo.Controls.Add(this.birthday);
            this.groupBoxInfo.Controls.Add(this.birthday_i);
            this.groupBoxInfo.Controls.Add(this.genre);
            this.groupBoxInfo.Controls.Add(this.genre_i);
            this.groupBoxInfo.Controls.Add(this.classn);
            this.groupBoxInfo.Controls.Add(this.class_i);
            this.groupBoxInfo.Location = new System.Drawing.Point(20, 70);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(360, 500);
            this.groupBoxInfo.TabIndex = 27;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin chi tiết";
            // 
            // mssv
            // 
            this.mssv.AutoSize = true;
            this.mssv.Location = new System.Drawing.Point(20, 40);
            this.mssv.Name = "mssv";
            this.mssv.Size = new System.Drawing.Size(100, 20);
            this.mssv.TabIndex = 4;
            this.mssv.Text = "Mã sinh viên:";
            // 
            // mssv_i
            // 
            this.mssv_i.Location = new System.Drawing.Point(20, 70);
            this.mssv_i.Name = "mssv_i";
            this.mssv_i.Size = new System.Drawing.Size(320, 26);
            this.mssv_i.TabIndex = 9;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(20, 120);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(81, 20);
            this.name.TabIndex = 5;
            this.name.Text = "Họ và tên:";
            // 
            // name_i
            // 
            this.name_i.Location = new System.Drawing.Point(20, 150);
            this.name_i.Name = "name_i";
            this.name_i.Size = new System.Drawing.Size(320, 26);
            this.name_i.TabIndex = 10;
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(20, 200);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(82, 20);
            this.birthday.TabIndex = 6;
            this.birthday.Text = "Ngày sinh:";
            // 
            // birthday_i
            // 
            this.birthday_i.CustomFormat = "dd/MM/yyyy";
            this.birthday_i.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthday_i.Location = new System.Drawing.Point(20, 230);
            this.birthday_i.Name = "birthday_i";
            this.birthday_i.Size = new System.Drawing.Size(320, 26);
            this.birthday_i.TabIndex = 13;
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(20, 280);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(71, 20);
            this.genre.TabIndex = 7;
            this.genre.Text = "Giới tính:";
            // 
            // genre_i
            // 
            this.genre_i.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genre_i.FormattingEnabled = true;
            this.genre_i.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.genre_i.Location = new System.Drawing.Point(20, 310);
            this.genre_i.Name = "genre_i";
            this.genre_i.Size = new System.Drawing.Size(320, 28);
            this.genre_i.TabIndex = 11;
            // 
            // classn
            // 
            this.classn.AutoSize = true;
            this.classn.Location = new System.Drawing.Point(20, 360);
            this.classn.Name = "classn";
            this.classn.Size = new System.Drawing.Size(40, 20);
            this.classn.TabIndex = 8;
            this.classn.Text = "Lớp:";
            // 
            // class_i
            // 
            this.class_i.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.class_i.FormattingEnabled = true;
            this.class_i.Items.AddRange(new object[] {
            "68PM1 - Lớp 68PM1",
            "68PM2 - Lớp 68PM2"});
            this.class_i.Location = new System.Drawing.Point(20, 390);
            this.class_i.Name = "class_i";
            this.class_i.Size = new System.Drawing.Size(320, 28);
            this.class_i.TabIndex = 12;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.Insert);
            this.groupBoxActions.Controls.Add(this.Update);
            this.groupBoxActions.Controls.Add(this.Delete);
            this.groupBoxActions.Controls.Add(this.Reset);
            this.groupBoxActions.Location = new System.Drawing.Point(20, 580);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(360, 180);
            this.groupBoxActions.TabIndex = 28;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Thao tác";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(20, 40);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(150, 50);
            this.Insert.TabIndex = 14;
            this.Insert.Text = "Thêm";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(190, 40);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(150, 50);
            this.Update.TabIndex = 15;
            this.Update.Text = "Sửa";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(20, 110);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(150, 50);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(190, 110);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(150, 50);
            this.Reset.TabIndex = 17;
            this.Reset.Text = "Làm mới";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.Search);
            this.groupBoxSearch.Controls.Add(this.textBox1);
            this.groupBoxSearch.Controls.Add(this.btn_search);
            this.groupBoxSearch.Location = new System.Drawing.Point(400, 40);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(1400, 100);
            this.groupBoxSearch.TabIndex = 29;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Tìm kiếm";
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(20, 40);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(211, 20);
            this.Search.TabIndex = 18;
            this.Search.Text = "Tìm kiếm (Tên/ Mã SV/ Lớp):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(950, 26);
            this.textBox1.TabIndex = 19;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1220, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(150, 46);
            this.btn_search.TabIndex = 20;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // TableSV
            // 
            this.TableSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.TableSV.Location = new System.Drawing.Point(400, 150);
            this.TableSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TableSV.Name = "TableSV";
            this.TableSV.RowHeadersWidth = 62;
            this.TableSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableSV.Size = new System.Drawing.Size(1400, 750);
            this.TableSV.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SV";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ và Tên";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Lớp";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // btn_first
            // 
            this.btn_first.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_first.Location = new System.Drawing.Point(400, 920);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(75, 40);
            this.btn_first.TabIndex = 22;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            // 
            // btn_prev
            // 
            this.btn_prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_prev.Location = new System.Drawing.Point(481, 920);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 40);
            this.btn_prev.TabIndex = 23;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.Location = new System.Drawing.Point(1639, 920);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 40);
            this.btn_next.TabIndex = 24;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_last
            // 
            this.btn_last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_last.Location = new System.Drawing.Point(1720, 920);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(75, 40);
            this.btn_last.TabIndex = 25;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            // 
            // lbl_pageinfo
            // 
            this.lbl_pageinfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_pageinfo.AutoSize = true;
            this.lbl_pageinfo.Location = new System.Drawing.Point(1000, 930);
            this.lbl_pageinfo.Name = "lbl_pageinfo";
            this.lbl_pageinfo.Size = new System.Drawing.Size(150, 20);
            this.lbl_pageinfo.TabIndex = 26;
            this.lbl_pageinfo.Text = "Trang 1/1 | 0 bản ghi";
            // 
            // UserControlQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.lbl_pageinfo);
            this.Controls.Add(this.TableSV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlQLSV";
            this.Size = new System.Drawing.Size(1836, 1009);
            ((System.ComponentModel.ISupportInitialize)(this.TableSV)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DateTimePicker birthday_i;
        private System.Windows.Forms.ComboBox class_i;
        private System.Windows.Forms.ComboBox genre_i;
        private System.Windows.Forms.TextBox name_i;
        private System.Windows.Forms.TextBox mssv_i;
        private System.Windows.Forms.Label classn;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label mssv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Label lbl_pageinfo;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.GroupBox groupBoxSearch;
    }
}