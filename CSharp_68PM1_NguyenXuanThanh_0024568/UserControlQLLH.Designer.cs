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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableLop)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(20, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(235, 37);
            this.lbTitle.TabIndex = 42;
            this.lbTitle.Text = "Quản lý Lớp học";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.maID);
            this.groupBoxInfo.Controls.Add(this.txtmaID);
            this.groupBoxInfo.Controls.Add(this.name);
            this.groupBoxInfo.Controls.Add(this.txtmaClass);
            this.groupBoxInfo.Controls.Add(this.birthday);
            this.groupBoxInfo.Controls.Add(this.txtnameClass);
            this.groupBoxInfo.Controls.Add(this.txtnote);
            this.groupBoxInfo.Controls.Add(this.textBox3);
            this.groupBoxInfo.Location = new System.Drawing.Point(20, 70);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(320, 380);
            this.groupBoxInfo.TabIndex = 65;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin chi tiết";
            // 
            // maID
            // 
            this.maID.AutoSize = true;
            this.maID.Location = new System.Drawing.Point(20, 40);
            this.maID.Name = "maID";
            this.maID.Size = new System.Drawing.Size(59, 20);
            this.maID.TabIndex = 43;
            this.maID.Text = "Mã ID:";
            // 
            // txtmaID
            // 
            this.txtmaID.Location = new System.Drawing.Point(20, 70);
            this.txtmaID.Name = "txtmaID";
            this.txtmaID.Size = new System.Drawing.Size(280, 26);
            this.txtmaID.TabIndex = 48;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(20, 120);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(60, 20);
            this.name.TabIndex = 44;
            this.name.Text = "Mã lớp:";
            // 
            // txtmaClass
            // 
            this.txtmaClass.Location = new System.Drawing.Point(20, 150);
            this.txtmaClass.Name = "txtmaClass";
            this.txtmaClass.Size = new System.Drawing.Size(280, 26);
            this.txtmaClass.TabIndex = 49;
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(20, 200);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(65, 20);
            this.birthday.TabIndex = 45;
            this.birthday.Text = "Tên lớp:";
            // 
            // txtnameClass
            // 
            this.txtnameClass.Location = new System.Drawing.Point(20, 230);
            this.txtnameClass.Name = "txtnameClass";
            this.txtnameClass.Size = new System.Drawing.Size(280, 26);
            this.txtnameClass.TabIndex = 61;
            // 
            // txtnote
            // 
            this.txtnote.AutoSize = true;
            this.txtnote.Location = new System.Drawing.Point(20, 280);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(68, 20);
            this.txtnote.TabIndex = 46;
            this.txtnote.Text = "Ghi chú:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 310);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(280, 26);
            this.textBox3.TabIndex = 61;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btn_add);
            this.groupBoxActions.Controls.Add(this.btn_Update);
            this.groupBoxActions.Controls.Add(this.btn_delete);
            this.groupBoxActions.Controls.Add(this.btn_reset);
            this.groupBoxActions.Controls.Add(this.btn_showSV);
            this.groupBoxActions.Location = new System.Drawing.Point(20, 460);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(320, 280);
            this.groupBoxActions.TabIndex = 66;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Thao tác";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(20, 40);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 50);
            this.btn_add.TabIndex = 53;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(170, 40);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(130, 50);
            this.btn_Update.TabIndex = 54;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(20, 110);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(130, 50);
            this.btn_delete.TabIndex = 55;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(170, 110);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(130, 50);
            this.btn_reset.TabIndex = 56;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_showSV
            // 
            this.btn_showSV.Location = new System.Drawing.Point(20, 180);
            this.btn_showSV.Name = "btn_showSV";
            this.btn_showSV.Size = new System.Drawing.Size(280, 50);
            this.btn_showSV.TabIndex = 64;
            this.btn_showSV.Text = "Xem danh sách sinh viên";
            this.btn_showSV.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.Search);
            this.groupBoxSearch.Controls.Add(this.txtSearch);
            this.groupBoxSearch.Controls.Add(this.btn_search);
            this.groupBoxSearch.Location = new System.Drawing.Point(360, 70);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(820, 100);
            this.groupBoxSearch.TabIndex = 67;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Tìm kiếm";
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(20, 40);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(243, 20);
            this.Search.TabIndex = 57;
            this.Search.Text = "Tìm kiếm (Mã ID/ Mã Lớp/ Tên Lớp):";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(280, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 26);
            this.txtSearch.TabIndex = 58;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(700, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 46);
            this.btn_search.TabIndex = 59;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // TableLop
            // 
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
            this.TableLop.Location = new System.Drawing.Point(360, 180);
            this.TableLop.Name = "TableLop";
            this.TableLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableLop.Size = new System.Drawing.Size(820, 500);
            this.TableLop.TabIndex = 60;
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
            // UserControlQLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLop);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.lbTitle);
            this.Name = "UserControlQLLH";
            this.Size = new System.Drawing.Size(1202, 760);
            this.Load += new System.EventHandler(this.UserControlQLLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableLop)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.GroupBox groupBoxSearch;
    }
}