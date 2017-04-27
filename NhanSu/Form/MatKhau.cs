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
    public partial class MatKhau : Form
    {
      //  private NguoiDungBLL nguoidung;
      //  NguoiDungEntities nguoidungenti;
        public MatKhau()
        {
            InitializeComponent();
            //nguoidung = new NguoiDungBLL();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
           
        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau formdoimk = new DoiMatKhau();
            formdoimk.Show();
        }
    }
}
