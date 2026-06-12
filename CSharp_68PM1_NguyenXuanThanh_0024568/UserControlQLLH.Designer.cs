namespace CSharp_68PM1_NguyenXuanThanh_0024568
{
    partial class UserControlQLLH
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
            this.components = new System.ComponentModel.Container();
            this.TableLop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtmaClass = new System.Windows.Forms.TextBox();
            this.txtmaID = new System.Windows.Forms.TextBox();
            this.txtnote = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.maID = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtnameClass = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_showSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableLop)).BeginInit();
            this.SuspendLayout();

            this.TableLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.TableLop.Location = new System.Drawing.Point(350, 227);
            this.TableLop.Name = "TableLop";
            this.TableLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableLop.Size = new System.Drawing.Size(800, 428);
            this.TableLop.TabIndex = 60;

            this.Column1.HeaderText = "Mã SV";
            this.Column1.Name = "Column1";

            this.Column2.HeaderText = "Họ và Tên";
            this.Column2.Name = "Column2";

            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";

            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.Name = "Column4";

            this.Column5.HeaderText = "Lớp";
            this.Column5.Name = "Column5";

            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(1055, 154);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(95, 39);
            this.btn_search.TabIndex = 59;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;

            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(350, 164);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(680, 20);
            this.txtSearch.TabIndex = 58;

            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(347, 121);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(275, 18);
            this.Search.TabIndex = 57;
            this.Search.Text = "Tìm kiếm(Mã ID/ Mã Lớp /Tên Lớp):";

            this.btn_reset.Location = new System.Drawing.Point(209, 507);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(104, 39);
            this.btn_reset.TabIndex = 56;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.UseVisualStyleBackColor = true;

            this.btn_delete.Location = new System.Drawing.Point(65, 507);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(101, 39);
            this.btn_delete.TabIndex = 55;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;

            this.btn_Update.Location = new System.Drawing.Point(209, 442);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(104, 43);
            this.btn_Update.TabIndex = 54;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;

            this.btn_add.Location = new System.Drawing.Point(65, 442);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(101, 43);
            this.btn_add.TabIndex = 53;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;

            this.txtmaClass.Location = new System.Drawing.Point(65, 215);
            this.txtmaClass.Name = "txtmaClass";
            this.txtmaClass.Size = new System.Drawing.Size(248, 20);
            this.txtmaClass.TabIndex = 49;

            this.txtmaID.Location = new System.Drawing.Point(65, 144);
            this.txtmaID.Name = "txtmaID";
            this.txtmaID.Size = new System.Drawing.Size(248, 20);
            this.txtmaID.TabIndex = 48;

            this.txtnote.AutoSize = true;
            this.txtnote.Location = new System.Drawing.Point(62, 340);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(47, 13);
            this.txtnote.TabIndex = 46;
            this.txtnote.Text = "Ghi chú:";

            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(62, 250);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(46, 13);
            this.birthday.TabIndex = 45;
            this.birthday.Text = "Tên lớp:";

            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(62, 184);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(46, 13);
            this.name.TabIndex = 44;
            this.name.Text = "Mã lớp:";

            this.maID.AutoSize = true;
            this.maID.Location = new System.Drawing.Point(62, 111);
            this.maID.Name = "maID";
            this.maID.Size = new System.Drawing.Size(39, 13);
            this.maID.TabIndex = 43;
            this.maID.Text = "Mã ID:";

            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(50, 66);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(139, 18);
            this.lbTitle.TabIndex = 42;
            this.lbTitle.Text = "Thông tin lớp học";
            this.lbTitle.Click += new System.EventHandler(this.label1_Click);

            this.txtnameClass.Location = new System.Drawing.Point(65, 285);
            this.txtnameClass.Name = "txtnameClass";
            this.txtnameClass.Size = new System.Drawing.Size(248, 20);
            this.txtnameClass.TabIndex = 61;

            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);

            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);

            this.textBox3.Location = new System.Drawing.Point(65, 384);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 20);
            this.textBox3.TabIndex = 61;

            this.btn_showSV.Location = new System.Drawing.Point(65, 574);
            this.btn_showSV.Name = "btn_showSV";
            this.btn_showSV.Size = new System.Drawing.Size(248, 40);
            this.btn_showSV.TabIndex = 64;
            this.btn_showSV.Text = "Xem danh sách sinh viên";
            this.btn_showSV.UseVisualStyleBackColor = true;

            this.AutoScroll = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_showSV);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtnameClass);
            this.Controls.Add(this.TableLop);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtmaClass);
            this.Controls.Add(this.txtmaID);
            this.Controls.Add(this.txtnote);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.name);
            this.Controls.Add(this.maID);
            this.Controls.Add(this.lbTitle);
            this.Name = "UserControlQLLH";
            this.Size = new System.Drawing.Size(1202, 706);
            this.Load += new System.EventHandler(this.UserControlQLLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtmaClass;
        private System.Windows.Forms.TextBox txtmaID;
        private System.Windows.Forms.Label txtnote;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label maID;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtnameClass;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_showSV;
    }
}