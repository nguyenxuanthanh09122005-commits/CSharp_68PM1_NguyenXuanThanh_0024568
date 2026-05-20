namespace CSharp_68PM1_NguyenXuanThanh_0024568
{
    partial class UserControlQLSV
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
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
            ((System.ComponentModel.ISupportInitialize)(this.TableSV)).BeginInit();
            this.SuspendLayout();
            // 
            // TableSV
            // 
            this.TableSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.TableSV.Location = new System.Drawing.Point(400, 130);
            this.TableSV.Name = "TableSV";
            this.TableSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableSV.Size = new System.Drawing.Size(774, 506);
            this.TableSV.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ và Tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Lớp";
            this.Column5.Name = "Column5";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(900, 80);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 30);
            this.btn_search.TabIndex = 20;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(400, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(480, 20);
            this.textBox1.TabIndex = 19;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(400, 50);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(224, 18);
            this.Search.TabIndex = 18;
            this.Search.Text = "Tìm kiếm(Tên/ Mã SV / Lớp):";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(200, 580);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 35);
            this.Reset.TabIndex = 17;
            this.Reset.Text = "Làm mới";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(50, 580);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 35);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(200, 530);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(100, 35);
            this.Update.TabIndex = 15;
            this.Update.Text = "Sửa";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(50, 530);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(100, 35);
            this.Insert.TabIndex = 14;
            this.Insert.Text = "Thêm";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // birthday_i
            // 
            this.birthday_i.CustomFormat = "dd/MM/yyyy";
            this.birthday_i.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthday_i.Location = new System.Drawing.Point(50, 300);
            this.birthday_i.Name = "birthday_i";
            this.birthday_i.Size = new System.Drawing.Size(250, 20);
            this.birthday_i.TabIndex = 13;
            // 
            // class_i
            // 
            this.class_i.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.class_i.FormattingEnabled = true;
            this.class_i.Items.AddRange(new object[] {
            "68PM1 - Lớp 68PM1",
            "68PM2 - Lớp 68PM2"});
            this.class_i.Location = new System.Drawing.Point(50, 450);
            this.class_i.Name = "class_i";
            this.class_i.Size = new System.Drawing.Size(250, 21);
            this.class_i.TabIndex = 12;
            // 
            // genre_i
            // 
            this.genre_i.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genre_i.FormattingEnabled = true;
            this.genre_i.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.genre_i.Location = new System.Drawing.Point(50, 370);
            this.genre_i.Name = "genre_i";
            this.genre_i.Size = new System.Drawing.Size(250, 21);
            this.genre_i.TabIndex = 11;
            // 
            // name_i
            // 
            this.name_i.Location = new System.Drawing.Point(50, 230);
            this.name_i.Name = "name_i";
            this.name_i.Size = new System.Drawing.Size(250, 20);
            this.name_i.TabIndex = 10;
            // 
            // mssv_i
            // 
            this.mssv_i.Location = new System.Drawing.Point(50, 160);
            this.mssv_i.Name = "mssv_i";
            this.mssv_i.Size = new System.Drawing.Size(250, 20);
            this.mssv_i.TabIndex = 9;
            // 
            // classn
            // 
            this.classn.AutoSize = true;
            this.classn.Location = new System.Drawing.Point(50, 420);
            this.classn.Name = "classn";
            this.classn.Size = new System.Drawing.Size(28, 13);
            this.classn.TabIndex = 8;
            this.classn.Text = "Lớp:";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(50, 340);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(50, 13);
            this.genre.TabIndex = 7;
            this.genre.Text = "Giới tính:";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(50, 270);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(57, 13);
            this.birthday.TabIndex = 6;
            this.birthday.Text = "Ngày sinh:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(50, 200);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(57, 13);
            this.name.TabIndex = 5;
            this.name.Text = "Họ và tên:";
            // 
            // mssv
            // 
            this.mssv.AutoSize = true;
            this.mssv.Location = new System.Drawing.Point(50, 130);
            this.mssv.Name = "mssv";
            this.mssv.Size = new System.Drawing.Size(70, 13);
            this.mssv.TabIndex = 4;
            this.mssv.Text = "Mã sinh viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // UserControlQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableSV);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.birthday_i);
            this.Controls.Add(this.class_i);
            this.Controls.Add(this.genre_i);
            this.Controls.Add(this.name_i);
            this.Controls.Add(this.mssv_i);
            this.Controls.Add(this.classn);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.name);
            this.Controls.Add(this.mssv);
            this.Controls.Add(this.label1);
            this.Name = "UserControlQLSV";
            this.Size = new System.Drawing.Size(1224, 656);
            ((System.ComponentModel.ISupportInitialize)(this.TableSV)).EndInit();
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
    }
}
