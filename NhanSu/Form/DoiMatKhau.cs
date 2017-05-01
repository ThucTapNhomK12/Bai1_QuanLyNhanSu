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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            NguoiDungBLL nguoidungbll=new NguoiDungBLL();
            string username = tbTenDangNhap.Text.Trim();
            string pass = tbMatKhauCu.Text.Trim();
            string passnew = tbMatKhauMoi.Text.Trim();
            string xacnhanpass = bXacNhanMK.Text.Trim();
            NguoiDungEntities nguoidungenti = new NguoiDungEntities();
            nguoidungenti.Username = tbTenDangNhap.Text.Trim();
            nguoidungenti.Pass = tbMatKhauCu.Text.Trim();
            nguoidungenti.Pass = tbMatKhauMoi.Text.Trim();
            nguoidungenti.Pass = bXacNhanMK.Text.Trim();
            if (nguoidungbll.DangNhap(username, pass))
            {
                nguoidungbll.update(nguoidungenti);
                MessageBox.Show("thay doi thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("thay doi that bai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btNhapLai_Click(object sender, EventArgs e)
        {
            tbTenDangNhap.Text = "";
            tbMatKhauCu.Text = "";
            tbMatKhauMoi.Text="";
            bXacNhanMK.Text="";
        }
    }
}
