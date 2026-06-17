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
            this.btn_search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtmaClass = new System.Windows.Forms.TextBox();
            this.txtnote = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtnameClass = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_showSV = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.lbl_pageinfo = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableLop)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
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
            this.Column5});
            this.TableLop.Location = new System.Drawing.Point(240, 117);
            this.TableLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TableLop.Name = "TableLop";
            this.TableLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableLop.Size = new System.Drawing.Size(547, 325);
            this.TableLop.TabIndex = 60;
            // 
            // btn_first
            // 
            this.btn_first.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_first.Location = new System.Drawing.Point(240, 450);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(50, 30);
            this.btn_first.TabIndex = 68;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            // 
            // btn_prev
            // 
            this.btn_prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_prev.Location = new System.Drawing.Point(295, 450);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(50, 30);
            this.btn_prev.TabIndex = 69;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.Location = new System.Drawing.Point(682, 450);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(50, 30);
            this.btn_next.TabIndex = 70;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_last
            // 
            this.btn_last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_last.Location = new System.Drawing.Point(737, 450);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(50, 30);
            this.btn_last.TabIndex = 71;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            // 
            // lbl_pageinfo
            // 
            this.lbl_pageinfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_pageinfo.AutoSize = true;
            this.lbl_pageinfo.Location = new System.Drawing.Point(440, 458);
            this.lbl_pageinfo.Name = "lbl_pageinfo";
            this.lbl_pageinfo.Size = new System.Drawing.Size(107, 13);
            this.lbl_pageinfo.TabIndex = 72;
            this.lbl_pageinfo.Text = "Trang 1/1 | 0 bản ghi";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(471, 18);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(67, 30);
            this.btn_search.TabIndex = 59;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(199, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(268, 20);
            this.txtSearch.TabIndex = 58;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(13, 26);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(182, 13);
            this.Search.TabIndex = 57;
            this.Search.Text = "Tìm kiếm (Mã ID/ Mã Lớp/ Tên Lớp):";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(113, 72);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(87, 32);
            this.btn_reset.TabIndex = 56;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(13, 72);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(87, 32);
            this.btn_delete.TabIndex = 55;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(113, 26);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 32);
            this.btn_Update.TabIndex = 54;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(13, 26);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(87, 32);
            this.btn_add.TabIndex = 53;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // txtmaClass
            // 
            this.txtmaClass.Location = new System.Drawing.Point(12, 55);
            this.txtmaClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmaClass.Name = "txtmaClass";
            this.txtmaClass.Size = new System.Drawing.Size(188, 20);
            this.txtmaClass.TabIndex = 49;
            // 
            // txtnote
            // 
            this.txtnote.AutoSize = true;
            this.txtnote.Location = new System.Drawing.Point(12, 139);
            this.txtnote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(47, 13);
            this.txtnote.TabIndex = 46;
            this.txtnote.Text = "Ghi chú:";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(12, 87);
            this.birthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(46, 13);
            this.birthday.TabIndex = 45;
            this.birthday.Text = "Tên lớp:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 35);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 13);
            this.name.TabIndex = 44;
            this.name.Text = "Mã lớp:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(13, 6);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(184, 25);
            this.lbTitle.TabIndex = 42;
            this.lbTitle.Text = "Quản lý Lớp học";
            // 
            // txtnameClass
            // 
            this.txtnameClass.Location = new System.Drawing.Point(12, 107);
            this.txtnameClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnameClass.Name = "txtnameClass";
            this.txtnameClass.Size = new System.Drawing.Size(188, 20);
            this.txtnameClass.TabIndex = 61;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 159);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 20);
            this.textBox3.TabIndex = 61;
            // 
            // btn_showSV
            // 
            this.btn_showSV.Location = new System.Drawing.Point(13, 117);
            this.btn_showSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_showSV.Name = "btn_showSV";
            this.btn_showSV.Size = new System.Drawing.Size(187, 32);
            this.btn_showSV.TabIndex = 64;
            this.btn_showSV.Text = "Xem danh sách sinh viên";
            this.btn_showSV.UseVisualStyleBackColor = true;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.name);
            this.groupBoxInfo.Controls.Add(this.txtmaClass);
            this.groupBoxInfo.Controls.Add(this.birthday);
            this.groupBoxInfo.Controls.Add(this.txtnameClass);
            this.groupBoxInfo.Controls.Add(this.txtnote);
            this.groupBoxInfo.Controls.Add(this.textBox3);
            this.groupBoxInfo.Location = new System.Drawing.Point(13, 46);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInfo.Size = new System.Drawing.Size(213, 247);
            this.groupBoxInfo.TabIndex = 65;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin chi tiết";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btn_add);
            this.groupBoxActions.Controls.Add(this.btn_Update);
            this.groupBoxActions.Controls.Add(this.btn_delete);
            this.groupBoxActions.Controls.Add(this.btn_reset);
            this.groupBoxActions.Controls.Add(this.btn_showSV);
            this.groupBoxActions.Location = new System.Drawing.Point(13, 299);
            this.groupBoxActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxActions.Size = new System.Drawing.Size(213, 182);
            this.groupBoxActions.TabIndex = 66;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Thao tác";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.Search);
            this.groupBoxSearch.Controls.Add(this.txtSearch);
            this.groupBoxSearch.Controls.Add(this.btn_search);
            this.groupBoxSearch.Location = new System.Drawing.Point(240, 46);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSearch.Size = new System.Drawing.Size(547, 65);
            this.groupBoxSearch.TabIndex = 67;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Tìm kiếm";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã lớp";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Lớp";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.Name = "Column5";
            // 
            // UserControlQLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.lbl_pageinfo);
            this.Controls.Add(this.TableLop);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlQLLH";
            this.Size = new System.Drawing.Size(801, 494);
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
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtmaClass;
        private System.Windows.Forms.Label txtnote;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtnameClass;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_showSV;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Label lbl_pageinfo;
    }
}