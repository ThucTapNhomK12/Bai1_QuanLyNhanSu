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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string Query = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Data();

            Load_khenthuong();

            ControllButton_khenthuong(1);

        }
        private void Load_Data()
        {
            //fill combobox
            KhenThuongBLL khenthuongbll = new KhenThuongBLL();
            cbbMaKhenThuong.DataSource = khenthuongbll.GetData();
            cbbMaKhenThuong.DisplayMember = "HinhThucKT";
            cbbMaKhenThuong.ValueMember = "MaKT";
            TrinhDoHocVanBLL trinhdobll = new TrinhDoHocVanBLL();
            cbbMaTDHV.DataSource = trinhdobll.GetData();
            cbbMaTDHV.DisplayMember = "TDHV";
            cbbMaTDHV.ValueMember = "MaTDHV";
        }

        #region"khenthuong"
        private void Load_khenthuong()
        {
            KhenThuongBLL khenthuongbll = new KhenThuongBLL();
            grvKhenThuong.DataSource = khenthuongbll.GetData();
        }
        private void btThemKT_Click(object sender, EventArgs e)
        {
            Query = "them";
            ControllButton_khenthuong(2);
            tbMaKT.Text = "";
            tbHinhThucKT.Text = "";
            tbLyDo.Text = "";
            tbMaKT.ReadOnly = false; ;
        }
        private void Excute_khenthuong(string querykt)
        {
            if (querykt == "them")
            {
                try
                {
                    //khoi tao doi tuong
                    KhenThuongEntities khenthuongenti = new KhenThuongEntities();
                    khenthuongenti.Makhenthuong = tbMaKT.Text.Trim();
                    khenthuongenti.Hinhthuckhenthuong = tbHinhThucKT.Text.Trim();
                    khenthuongenti.Lydokhenthuong = tbLyDo.Text.Trim();
                    KhenThuongBLL khenthuongbll = new KhenThuongBLL();
                    if (!(khenthuongbll.Checkkt(tbMaKT.Text.Trim())))
                    {
                        khenthuongbll.insert(khenthuongenti);
                        Load_khenthuong();
                    }
                    else
                        MessageBox.Show("Ma khen thuong:" + makt + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("them bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            if (querykt == "sua")
            {
                try
                {
                    //khoi tao doi tuong
                    KhenThuongEntities khenthuongenti = new KhenThuongEntities();
                    khenthuongenti.Makhenthuong = tbMaKT.Text.Trim();
                    khenthuongenti.Hinhthuckhenthuong = tbHinhThucKT.Text.Trim();
                    khenthuongenti.Lydokhenthuong = tbLyDo.Text.Trim();
                    KhenThuongBLL khenthuongbll = new KhenThuongBLL();
                    khenthuongbll.update(khenthuongenti);
                    Load_khenthuong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (querykt == "xoa")
            {
                try
                {
                    string makt = tbMaKT.Text.Trim();
                    KhenThuongBLL khenthuongbll = new KhenThuongBLL();
                    khenthuongbll.delete(makt);
                    Load_khenthuong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btSuaKT_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ControllButton_khenthuong(2);
            tbMaKT.ReadOnly = true;
        }

        private void btXoaKT_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ControllButton_khenthuong(2);
        }

        private void btLuuKT_Click(object sender, EventArgs e)
        {
            Excute_khenthuong(Query);
            ControllButton_khenthuong(1);
        }

        private void btHuyKT_Click(object sender, EventArgs e)
        {
            ControllButton_khenthuong(1);
        }
        private void ControllButton_khenthuong(int type)
        {
            btThemKT.Visible = type == 1 ? true : false;
            btSuaKT.Visible = type == 1 ? true : false;
            btXoaKT.Visible = type == 1 ? true : false;
            btLuuKT.Visible = type == 2 ? true : false;
            btHuyKT.Visible = type == 2 ? true : false;
        }

        private void grvKhenThuong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbMaKT.Text = grvKhenThuong["Column3", index].Value.ToString();
            tbHinhThucKT.Text = grvKhenThuong["HinhThucKT", index].Value.ToString();
            tbLyDo.Text = grvKhenThuong["Column4", index].Value.ToString();
        }
        #endregion

        #region"hocvan"
        private void Load_trinhdohocvan()
        {
            TrinhDoHocVanBLL trinhdobll = new TrinhDoHocVanBLL();
            grvTrinhDo.DataSource = trinhdobll.GetData();
        }
        private void btThemTD_Click(object sender, EventArgs e)
        {
            Query = "them";
            ControllButton_trinhdo(2);
            tbMaTDHV.Text = "";
            tbTrinhDo.Text = "";
            tbChuyenNganh.Text = "";
        }
        private void Excute_trinhdo(string querytd)
        {
            if (querytd == "them")
            {
                try
                {
                    //khoi tao doi tuong
                    TrinhDoHocVanEntities trinhdoenti = new TrinhDoHocVanEntities();
                    trinhdoenti.Matrinhdohocvan = tbMaTDHV.Text.Trim();
                    trinhdoenti.Trinhdohocvan = tbTrinhDo.Text.Trim();
                    trinhdoenti.Chuyennganh = tbChuyenNganh.Text.Trim();
                    TrinhDoHocVanBLL trinhdobll = new TrinhDoHocVanBLL();
                    if (!(trinhdobll.Checktdhv(tbMaTDHV.Text.Trim())))
                    {
                        trinhdobll.Insert(trinhdoenti);
                        Load_trinhdohocvan();
                    }
                    else
                        MessageBox.Show("Ma trinh do hoc van:" + Matrinhdohocvan + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("them bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            if (querytd == "sua")
            {
                try
                {
                    //khoi tao doi tuong
                    TrinhDoHocVanEntities trinhdoenti = new TrinhDoHocVanEntities();
                    trinhdoenti.Matrinhdohocvan = tbMaTDHV.Text.Trim();
                    trinhdoenti.Trinhdohocvan = tbTrinhDo.Text.Trim();
                    trinhdoenti.Chuyennganh = tbChuyenNganh.Text.Trim();
                    TrinhDoHocVanBLL trinhdobll = new TrinhDoHocVanBLL();
                    trinhdobll.update(trinhdoenti);
                    Load_trinhdohocvan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (querytd == "xoa")
            {
                try
                {
                    string matdhv = tbMaTDHV.Text.Trim();
                    TrinhDoHocVanBLL trinhdobll = new TrinhDoHocVanBLL();
                    trinhdobll.delete(matdhv);
                    Load_trinhdohocvan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("xoa bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void grvTrinhDo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbMaTDHV.Text = grvTrinhDo["Column", index].Value.ToString();
            tbTrinhDo.Text = grvTrinhDo["TDHV", index].Value.ToString();
            tbChuyenNganh.Text = grvTrinhDo["ChuyenNganh", index].Value.ToString();
        }
        private void btSuaTD_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ControllButton_trinhdo(2);
            tbMaTDHV.ReadOnly = true;
        }

        private void btXoaTD_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ControllButton_trinhdo(2);
        }

        private void btLuuTD_Click(object sender, EventArgs e)
        {
            Excute_trinhdo(Query);
            ControllButton_trinhdo(1);
        }

        private void btHuyTD_Click(object sender, EventArgs e)
        {
            ControllButton_trinhdo(1);
        }
        private void ControllButton_trinhdo(int type)
        {
            btThemTD.Visible = type == 1 ? true : false;
            btSuaTD.Visible = type == 1 ? true : false;
            btXoaTD.Visible = type == 1 ? true : false;
            btLuuTD.Visible = type == 2 ? true : false;
            btHuyTD.Visible = type == 2 ? true : false;
        }


        public string Matrinhdohocvan { get; set; }
        #endregion
    }
}
