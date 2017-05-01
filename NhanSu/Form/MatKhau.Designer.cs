namespace NhanSu
{
    partial class MatKhau
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
            this.lbQuenMK = new System.Windows.Forms.LinkLabel();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btDoiMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbQuenMK
            // 
            this.lbQuenMK.AutoSize = true;
            this.lbQuenMK.Location = new System.Drawing.Point(171, 161);
            this.lbQuenMK.Name = "lbQuenMK";
            this.lbQuenMK.Size = new System.Drawing.Size(86, 13);
            this.lbQuenMK.TabIndex = 2;
            this.lbQuenMK.TabStop = true;
            this.lbQuenMK.Text = "Quên mật khẩu?";
            this.lbQuenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(135, 39);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(194, 20);
            this.tbusername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(135, 95);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(194, 20);
            this.tbpassword.TabIndex = 3;
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(161, 209);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btDangNhap.TabIndex = 0;
            this.btDangNhap.Text = "Đăng Nhập ";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btDoiMK
            // 
            this.btDoiMK.Location = new System.Drawing.Point(27, 209);
            this.btDoiMK.Name = "btDoiMK";
            this.btDoiMK.Size = new System.Drawing.Size(87, 23);
            this.btDoiMK.TabIndex = 0;
            this.btDoiMK.Text = "Đổi Mật Khẩu";
            this.btDoiMK.UseVisualStyleBackColor = true;
            this.btDoiMK.Click += new System.EventHandler(this.btDoiMK_Click);
            // 
            // MatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 261);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbQuenMK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDoiMK);
            this.Controls.Add(this.btDangNhap);
            this.Name = "MatKhau";
            this.Text = "MatKhau";
            this.Load += new System.EventHandler(this.MatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbQuenMK;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btDoiMK;
    }
}