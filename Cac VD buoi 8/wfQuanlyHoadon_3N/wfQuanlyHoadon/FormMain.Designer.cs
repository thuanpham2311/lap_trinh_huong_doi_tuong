namespace wfQuanlyHoadon
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hanghoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoadonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hanghoaToolStripMenuItem,
            this.hoadonToolStripMenuItem,
            this.ghiDữLiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hanghoaToolStripMenuItem
            // 
            this.hanghoaToolStripMenuItem.Name = "hanghoaToolStripMenuItem";
            this.hanghoaToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.hanghoaToolStripMenuItem.Text = "Quản lý hàng hóa";
            this.hanghoaToolStripMenuItem.Click += new System.EventHandler(this.hanghoaToolStripMenuItem_Click_1);
            // 
            // hoadonToolStripMenuItem
            // 
            this.hoadonToolStripMenuItem.Name = "hoadonToolStripMenuItem";
            this.hoadonToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.hoadonToolStripMenuItem.Text = "Quản lý hóa đơn";
            this.hoadonToolStripMenuItem.Click += new System.EventHandler(this.hoadonToolStripMenuItem_Click);
            // 
            // ghiDữLiệuToolStripMenuItem
            // 
            this.ghiDữLiệuToolStripMenuItem.Name = "ghiDữLiệuToolStripMenuItem";
            this.ghiDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ghiDữLiệuToolStripMenuItem.Text = "Ghi dữ liệu";
            this.ghiDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.ghiDữLiệuToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 501);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hanghoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoadonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiDữLiệuToolStripMenuItem;
    }
}

