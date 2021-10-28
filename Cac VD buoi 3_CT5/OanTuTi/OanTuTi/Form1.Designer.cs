namespace OanTuTi
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBua = new System.Windows.Forms.RadioButton();
            this.radBao = new System.Windows.Forms.RadioButton();
            this.radKeo = new System.Windows.Forms.RadioButton();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnChoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radKeo);
            this.groupBox1.Controls.Add(this.radBao);
            this.groupBox1.Controls.Add(this.radBua);
            this.groupBox1.Location = new System.Drawing.Point(31, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn chọn";
            // 
            // radBua
            // 
            this.radBua.AutoSize = true;
            this.radBua.Location = new System.Drawing.Point(26, 35);
            this.radBua.Name = "radBua";
            this.radBua.Size = new System.Drawing.Size(68, 24);
            this.radBua.TabIndex = 0;
            this.radBua.TabStop = true;
            this.radBua.Text = "BÚA";
            this.radBua.UseVisualStyleBackColor = true;
            // 
            // radBao
            // 
            this.radBao.AutoSize = true;
            this.radBao.Location = new System.Drawing.Point(248, 35);
            this.radBao.Name = "radBao";
            this.radBao.Size = new System.Drawing.Size(68, 24);
            this.radBao.TabIndex = 1;
            this.radBao.TabStop = true;
            this.radBao.Text = "BAO";
            this.radBao.UseVisualStyleBackColor = true;
            // 
            // radKeo
            // 
            this.radKeo.AutoSize = true;
            this.radKeo.Location = new System.Drawing.Point(500, 35);
            this.radKeo.Name = "radKeo";
            this.radKeo.Size = new System.Drawing.Size(67, 24);
            this.radKeo.TabIndex = 2;
            this.radKeo.TabStop = true;
            this.radKeo.Text = "KÉO";
            this.radKeo.UseVisualStyleBackColor = true;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(36, 208);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(51, 20);
            this.lblKQ.TabIndex = 1;
            this.lblKQ.Text = "label1";
            // 
            // btnChoi
            // 
            this.btnChoi.Location = new System.Drawing.Point(90, 302);
            this.btnChoi.Name = "btnChoi";
            this.btnChoi.Size = new System.Drawing.Size(189, 52);
            this.btnChoi.TabIndex = 2;
            this.btnChoi.Text = "Chơi";
            this.btnChoi.UseVisualStyleBackColor = true;
            this.btnChoi.Click += new System.EventHandler(this.btnChoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(409, 302);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(189, 52);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChoi);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radKeo;
        private System.Windows.Forms.RadioButton radBao;
        private System.Windows.Forms.RadioButton radBua;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnChoi;
        private System.Windows.Forms.Button btnThoat;
    }
}

