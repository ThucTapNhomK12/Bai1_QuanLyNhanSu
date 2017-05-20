namespace NhanSu
{
    partial class DoiMatKhau
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
            this.tbMatKhauCu = new System.Windows.Forms.TextBox();
            this.btNhapLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bXacNhanMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.tbTenDangNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMatKhauCu
            // 
            this.tbMatKhauCu.Location = new System.Drawing.Point(150, 85);
            this.tbMatKhauCu.Name = "tbMatKhauCu";
            this.tbMatKhauCu.Size = new System.Drawing.Size(205, 20);
            this.tbMatKhauCu.TabIndex = 0;
            // 
            // btNhapLai
            // 
            this.btNhapLai.Location = new System.Drawing.Point(191, 226);
            this.btNhapLai.Name = "btNhapLai";
            this.btNhapLai.Size = new System.Drawing.Size(75, 23);
            this.btNhapLai.TabIndex = 1;
            this.btNhapLai.Text = "Nhap Lại";
            this.btNhapLai.UseVisualStyleBackColor = true;
            this.btNhapLai.Click += new System.EventHandler(this.btNhapLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật Khẩu cũ";
            // 
            // bXacNhanMK
            // 
            this.bXacNhanMK.Location = new System.Drawing.Point(150, 180);
            this.bXacNhanMK.Name = "bXacNhanMK";
            this.bXacNhanMK.Size = new System.Drawing.Size(205, 20);
            this.bXacNhanMK.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xac Nhận Lại Mật Khẩu";
            // 
            // tbMatKhauMoi
            // 
            this.tbMatKhauMoi.Location = new System.Drawing.Point(150, 133);
            this.tbMatKhauMoi.Name = "tbMatKhauMoi";
            this.tbMatKhauMoi.Size = new System.Drawing.Size(205, 20);
            this.tbMatKhauMoi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu Mới";
            // 
            // btXacNhan
            // 
            this.btXacNhan.Location = new System.Drawing.Point(93, 226);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btXacNhan.TabIndex = 1;
            this.btXacNhan.Text = "Xác Nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // tbTenDangNhap
            // 
            this.tbTenDangNhap.Location = new System.Drawing.Point(150, 38);
            this.tbTenDangNhap.Name = "tbTenDangNhap";
            this.tbTenDangNhap.Size = new System.Drawing.Size(205, 20);
            this.tbTenDangNhap.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ten Dang Nhap";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.btNhapLai);
            this.Controls.Add(this.tbMatKhauMoi);
            this.Controls.Add(this.bXacNhanMK);
            this.Controls.Add(this.tbTenDangNhap);
            this.Controls.Add(this.tbMatKhauCu);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMatKhauCu;
        private System.Windows.Forms.Button btNhapLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bXacNhanMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMatKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.TextBox tbTenDangNhap;
        private System.Windows.Forms.Label label4;
    }
}