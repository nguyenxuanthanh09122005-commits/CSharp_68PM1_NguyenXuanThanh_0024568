namespace CSharp_68PM1_NguyenXuanThanh_0024568
{
    partial class Form_Main
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlQLSV = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSinhViênToolStripMenuItem,
            this.quảnLýLớpHọcToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1351, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý sinh viên";

            this.quảnLýLớpHọcToolStripMenuItem.Name = "quảnLýLớpHọcToolStripMenuItem";
            this.quảnLýLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.quảnLýLớpHọcToolStripMenuItem.Text = "Quản lý lớp học";
            this.quảnLýLớpHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLớpHọcToolStripMenuItem_Click);

            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";

            this.pnlQLSV.BackColor = System.Drawing.SystemColors.Control;
            this.pnlQLSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQLSV.Location = new System.Drawing.Point(0, 24);
            this.pnlQLSV.Name = "pnlQLSV";
            this.pnlQLSV.Size = new System.Drawing.Size(1351, 680);
            this.pnlQLSV.TabIndex = 1;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 704);
            this.Controls.Add(this.pnlQLSV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "Hệ thống quản lý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel pnlQLSV;
    }
}