using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhanSu.Business;
using NhanSu.Entities;

namespace NhanSu
{
    public partial class MatKhau : Form
    {
        private NguoiDungBLL nguoidung;
        NguoiDungEntities nguoidungenti;
        public MatKhau()
        {
            InitializeComponent();
            nguoidung = new NguoiDungBLL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void MatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            NguoiDungBLL nguoidungbll = new NguoiDungBLL();
            string username = tbusername.Text.ToString();
            string pass = tbpassword.Text.ToString();
            if (nguoidungbll.DangNhap(username,pass))
            {
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                MessageBox.Show("loi dang nhap", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbusername.Text = "";
                tbpassword.Text = "";
            }
        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau formdoimk = new DoiMatKhau();
            formdoimk.Show();
        }
    }
}
