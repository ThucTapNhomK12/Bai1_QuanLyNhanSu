using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
