namespace wfQuanlyHoadon
{
    partial class FormHoadon
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSohd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaylaphd = new System.Windows.Forms.DateTimePicker();
            this.btnLaphd = new System.Windows.Forms.Button();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMahang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDvt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btbChonhh = new System.Windows.Forms.Button();
            this.lst = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNgaylapHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hóa đơn:";
            // 
            // txtSohd
            // 
            this.txtSohd.Location = new System.Drawing.Point(18, 63);
            this.txtSohd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSohd.Name = "txtSohd";
            this.txtSohd.Size = new System.Drawing.Size(223, 26);
            this.txtSohd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày lập hóa đơn:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(471, 63);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(418, 26);
            this.txtTenKH.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên khách hàng:";
            // 
            // dtpNgaylaphd
            // 
            this.dtpNgaylaphd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylaphd.Location = new System.Drawing.Point(250, 63);
            this.dtpNgaylaphd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgaylaphd.Name = "dtpNgaylaphd";
            this.dtpNgaylaphd.Size = new System.Drawing.Size(212, 26);
            this.dtpNgaylaphd.TabIndex = 5;
            // 
            // btnLaphd
            // 
            this.btnLaphd.Location = new System.Drawing.Point(903, 65);
            this.btnLaphd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLaphd.Name = "btnLaphd";
            this.btnLaphd.Size = new System.Drawing.Size(147, 35);
            this.btnLaphd.TabIndex = 6;
            this.btnLaphd.Text = "Lập hóa đơn";
            this.btnLaphd.UseVisualStyleBackColor = true;
            this.btnLaphd.Click += new System.EventHandler(this.btnLaphd_Click);
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(204, 138);
            this.txtTenhang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(296, 26);
            this.txtTenhang.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên hàng:";
            // 
            // cmbMahang
            // 
            this.cmbMahang.FormattingEnabled = true;
            this.cmbMahang.Location = new System.Drawing.Point(18, 137);
            this.cmbMahang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMahang.Name = "cmbMahang";
            this.cmbMahang.Size = new System.Drawing.Size(180, 28);
            this.cmbMahang.TabIndex = 9;
            this.cmbMahang.SelectedIndexChanged += new System.EventHandler(this.cmbMahang_SelectedIndexChanged);
            this.cmbMahang.Click += new System.EventHandler(this.cmbMahang_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã hàng:";
            // 
            // txtDvt
            // 
            this.txtDvt.Location = new System.Drawing.Point(510, 138);
            this.txtDvt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(115, 26);
            this.txtDvt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Đơn vị tính:";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(633, 138);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(115, 26);
            this.txtDongia.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(633, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Đơn giá:";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(756, 138);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(115, 26);
            this.txtSoluong.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(756, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Số lượng:";
            // 
            // btbChonhh
            // 
            this.btbChonhh.Location = new System.Drawing.Point(903, 135);
            this.btbChonhh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btbChonhh.Name = "btbChonhh";
            this.btbChonhh.Size = new System.Drawing.Size(147, 35);
            this.btbChonhh.TabIndex = 19;
            this.btbChonhh.Text = "Chọn hàng hóa";
            this.btbChonhh.UseVisualStyleBackColor = true;
            this.btbChonhh.Click += new System.EventHandler(this.btbChonhh_Click);
            // 
            // lst
            // 
            this.lst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lst.FullRowSelect = true;
            this.lst.GridLines = true;
            this.lst.HideSelection = false;
            this.lst.Location = new System.Drawing.Point(1064, 92);
            this.lst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(390, 413);
            this.lst.TabIndex = 21;
            this.lst.UseCompatibleStateImageBehavior = false;
            this.lst.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số hóa đơn";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày lập";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên khách hàng";
            this.columnHeader3.Width = 137;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1059, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Danh mục hóa đơn:";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(1179, 517);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(147, 35);
            this.btnXem.TabIndex = 24;
            this.btnXem.Text = "Xem hóa đơn";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv.Location = new System.Drawing.Point(18, 178);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1036, 329);
            this.dgv.TabIndex = 25;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "sohd";
            this.Column7.HeaderText = "Số HD";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ngaylaphd";
            this.Column8.HeaderText = "Ngày lập HD";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "tenkh";
            this.Column9.HeaderText = "Tên KH";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mahang";
            this.Column1.HeaderText = "Mã hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenhang";
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dvt";
            this.Column3.HeaderText = "Đơn vị tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dongia";
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "soluong";
            this.Column5.HeaderText = "Số lượng";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "thanhtien";
            this.Column6.HeaderText = "Thành tiền";
            this.Column6.Name = "Column6";
            // 
            // btnNgaylapHD
            // 
            this.btnNgaylapHD.Location = new System.Drawing.Point(948, 517);
            this.btnNgaylapHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNgaylapHD.Name = "btnNgaylapHD";
            this.btnNgaylapHD.Size = new System.Drawing.Size(198, 35);
            this.btnNgaylapHD.TabIndex = 26;
            this.btnNgaylapHD.Text = "Ngày lập hóa đơn";
            this.btnNgaylapHD.UseVisualStyleBackColor = true;
            this.btnNgaylapHD.Click += new System.EventHandler(this.btnNgaylapHD_Click);
            // 
            // FormHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 558);
            this.Controls.Add(this.btnNgaylapHD);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.btbChonhh);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDvt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMahang);
            this.Controls.Add(this.txtTenhang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLaphd);
            this.Controls.Add(this.dtpNgaylaphd);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSohd);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHoadon";
            this.Text = "FormHoadon";
            this.Load += new System.EventHandler(this.FormHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSohd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaylaphd;
        private System.Windows.Forms.Button btnLaphd;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMahang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btbChonhh;
        private System.Windows.Forms.ListView lst;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnNgaylapHD;
    }
}