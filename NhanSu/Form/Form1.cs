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
		
		#region"NhanVien"
        private void btThem_Click(object sender, EventArgs e)
        {
            //kho tao doi tuong
            Query = "them";
            ControllButton(2);
            tbMaNV.Text = "";
            tbHoTen.Text = "";
            tbNamSinh.Text = "";
            tbGioiTinh.Text = "";
            tbDiaChi.Text = "";
            tbDanToc.Text = "";
            tbTonGiao.Text = "";
            tbCMTND.Text = "";
            tbHonNhan.Text = "";
            tbSoDienThoai.Text = "";
            tbGhiChu.Text = "";
            tbMaSoLuong.Text = "";
            cbbMaPhongBan.SelectedValue = "";
            tbMaPhongBan.Text = "";
            cbbMaChucVu.SelectedValue = "";
            cbbMaTDHV.SelectedValue = "";
            tbNgoaiNgu.Text = "";
            tbMaHopDong.Text = "";
            tbBaoHiem.Text = "";
            cbbMaKhenThuong.SelectedValue = "";
            cbbMaKyLuat.SelectedValue = "";
            tbMa.ReadOnly = false;
        }
        private void Excute(string query)
        {
            if (query == "them")
            {
                try
                {
                    NhanVienEntities obj_nv = new NhanVienEntities();
                    obj_nv.Manv = tbMaNV.Text.Trim();
                    obj_nv.Hoten = tbHoTen.Text.Trim();
                    obj_nv.Ngaysinh = tbNamSinh.Text.Trim();
                    obj_nv.Gioitinh = tbGioiTinh.Text.Trim();
                    obj_nv.DiaChi = tbDiaChi.Text.Trim();
                    obj_nv.Dantoc = tbDanToc.Text.Trim();
                    obj_nv.TonGiao = tbTonGiao.Text.Trim();
                    obj_nv.CMTND = tbCMTND.Text.Trim();
                    obj_nv.TinhTrangHonNhan = tbHonNhan.Text.Trim();
                    obj_nv.MaPhongBan = cbbMaPhongBan.SelectedValue.ToString().Trim();
                    obj_nv.SoDienThoai = tbSoDienThoai.Text.Trim();
                    obj_nv.GhiChu = tbGhiChu.Text.Trim();
                    // obj_nv.MaSoLuong = tbMaSoLuong.Text.Trim();
                    obj_nv.MaChucVu = cbbMaChucVu.SelectedValue.ToString().Trim();
                    obj_nv.MaTDHV = cbbMaTDHV.SelectedValue.ToString().Trim();
                    obj_nv.NgoaiNgu = tbNgoaiNgu.Text.Trim();
                    obj_nv.MaHD = tbMaHopDong.Text.Trim();
                    obj_nv.MaSBH = tbBaoHiem.Text.Trim();
                    obj_nv.MaKT = cbbMaKhenThuong.SelectedValue.ToString().Trim();
                    obj_nv.MaKL = cbbMaKyLuat.SelectedValue.ToString().Trim();
                   
                    NhanVienBLL nv = new NhanVienBLL();
                    if (!(nv.CheckID(tbMaNV.Text.Trim())))
                    {
                        nv.insert(obj_nv);
                        Load_Data();
                    }
                    else
                        MessageBox.Show("ma nhan vien" + manv + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("them bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (query == "sua")
            {
                try
                {
                    NhanVienEntities obj_nv = new NhanVienEntities();
                    obj_nv.Manv = tbMaNV.Text.Trim();
                    obj_nv.Hoten = tbHoTen.Text.Trim();
                    obj_nv.Ngaysinh = tbNamSinh.Text.Trim();
                    obj_nv.Gioitinh = tbGioiTinh.Text.Trim();
                    obj_nv.DiaChi = tbDiaChi.Text.Trim();
                    obj_nv.Dantoc = tbDanToc.Text.Trim();
                    obj_nv.TonGiao = tbTonGiao.Text.Trim();
                    obj_nv.CMTND = tbCMTND.Text.Trim();
                    obj_nv.TinhTrangHonNhan = tbHonNhan.Text.Trim();
                    obj_nv.SoDienThoai = tbSoDienThoai.Text.Trim();
                    obj_nv.GhiChu = tbGhiChu.Text.Trim();
                    obj_nv.MaSoLuong = tbMaSoLuong.Text.Trim();
                    obj_nv.MaPhongBan = cbbMaPhongBan.SelectedValue.ToString().Trim();
                    obj_nv.MaChucVu = cbbMaChucVu.SelectedValue.ToString().Trim();
                    obj_nv.MaTDHV = cbbMaTDHV.SelectedValue.ToString().Trim();
                    obj_nv.NgoaiNgu = tbNgoaiNgu.Text.Trim();
                    obj_nv.MaHD = tbMaHopDong.Text.Trim();
                    obj_nv.MaSBH = tbBaoHiem.Text.Trim();
                    obj_nv.MaKL = cbbMaKyLuat.SelectedValue.ToString().Trim();
                    obj_nv.MaKT = cbbMaKhenThuong.SelectedValue.ToString().Trim();
                    NhanVienBLL nv = new NhanVienBLL();
                    //string manv = tbMaNV.Text.Trim();
                    nv.update(obj_nv);
                    Load_Data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (query == "xoa")
            {
                try
                {
                    string manv = tbMa.Text.Trim();
                    NhanVienBLL nv = new NhanVienBLL();
                    nv.delete(manv);
                    Load_Data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("xoa bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ControllButton(2);
            tbMa.ReadOnly = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ControllButton(2);
        }

        private void grvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbMaNV.Text = grvNhanVien["manv", index].Value.ToString();
            tbHoTen.Text = grvNhanVien["hoten", index].Value.ToString();
            tbNamSinh.Text = grvNhanVien["ngaysinh", index].Value.ToString();
            tbGioiTinh.Text = grvNhanVien["gioitinh", index].Value.ToString();
            tbDiaChi.Text = grvNhanVien["diachi", index].Value.ToString();
            tbDanToc.Text = grvNhanVien["dantoc", index].Value.ToString();
            tbTonGiao.Text = grvNhanVien["tongiao", index].Value.ToString();
            tbCMTND.Text = grvNhanVien["cmtnd", index].Value.ToString();
            tbHonNhan.Text = grvNhanVien["honnhan", index].Value.ToString();
            tbSoDienThoai.Text = grvNhanVien["sodienthoai", index].Value.ToString();
            tbGhiChu.Text = grvNhanVien["ghichu", index].Value.ToString();
           // tbMaSoLuong.Text = grvNhanVien["masl", index].Value.ToString();
            cbbMaPhongBan.SelectedValue = grvNhanVien["mapb", index].Value.ToString();
            cbbMaChucVu.SelectedValue = grvNhanVien["macv", index].Value.ToString();
            cbbMaTDHV.SelectedValue = grvNhanVien["hocvan", index].Value.ToString();
            tbNgoaiNgu.Text = grvNhanVien["ngoaingu", index].Value.ToString();
            tbMaHopDong.Text = grvNhanVien["mahd", index].Value.ToString();
            tbBaoHiem.Text = grvNhanVien["mabaohiem", index].Value.ToString();
            cbbMaKyLuat.SelectedValue = grvNhanVien["makl", index].Value.ToString();
            cbbMaKhenThuong.SelectedValue = grvNhanVien["makt", index].Value.ToString();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            Excute(Query);
            ControllButton(1);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            ControllButton(1);
        }
        private void ControllButton(int type)
        {
            btThem.Visible = type == 1 ? true : false;
            btSua.Visible = type == 1 ? true : false;
            btXoa.Visible = type == 1 ? true : false;
            btluu.Visible = type == 2 ? true : false;
            btHuy.Visible = type == 2 ? true : false;
        }
        #endregion
        #region"luong"  
        private void Load_LuongNV()
        {
            LuongBLL luong = new LuongBLL();
            grvLuong.DataSource = luong.GetData();
        }


        private void btThemLuong_Click(object sender, EventArgs e)
        {
            Query = "them";
            ControllButton_luong(2);
            tbMa.Text = "";
            tbMaSoLuong.Text = "";
            tbSoNgayCong.Text = "";
            tbPhuCap.Text = "";
            tbMaSL.Text = "";
            tbGioLamThem.Text = "";
            tbHeSoLuong.Text = "";
            tbThuong.Text = "";
            tbTamUng.Text = "";
            tbNgayLap.Text = "";
            tbMaSL.ReadOnly = false;
        }

        private void btSualuong_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ControllButton_luong(2);
            tbMaSL.ReadOnly = true;
        }


        private void btLuuLuong_Click(object sender, EventArgs e)
        {
            Excute_luong(Query);
            ControllButton_luong(1);
        }

        private void btHuyLuong_Click(object sender, EventArgs e)
        {
            ControllButton_luong(1);
        }

        private void btTinhLuong_Click(object sender, EventArgs e)
        {

        }
        private void Excute_luong(string query)
        {
            if (query == "them")
            {
                try
                {
                    LuongEntities obj_luong = new LuongEntities();
                    obj_luong.MaNV1 = tbMa.Text.Trim();
                    obj_luong.MaSL1 = tbMaSL.Text.Trim();
                    obj_luong.SoNgayCong1 = Convert.ToInt32(tbSoNgayCong.Text);
                    obj_luong.PhuCapCV1 = Convert.ToInt32(tbPhuCap.Text);
                    obj_luong.HeSoLuong1 = tbHeSoLuong.Text.Trim();
                    obj_luong.SoGiolamThem1 = Convert.ToInt32(tbGioLamThem.Text);
                    obj_luong.Thuong1 = Convert.ToInt32(tbThuong.Text);
                    obj_luong.TamUng1 = Convert.ToInt32(tbTamUng.Text);
                    /*obj_luong.MaSoLuong1 = tbMaSoLuong.Text.Trim();
                    obj_luong.SoNgayCong1 = tbSoNgayCong.Text.Trim();
                    obj_luong.PhuCapCV1 = tbPhuCap.Text.Trim();
                    obj_luong.MaSL1=tbMaSL.Text.Trim();
                    obj_luong.SoGiolamThem1 = tbGioLamThem.Text.Trim();
                    obj_luong.HeSoLuong1 = tbHeSoLuong.Text.Trim();
                    obj_luong.Thuong1 = tbThuong.Text.Trim();
                    obj_luong.TamUng1 = tbTamUng.Text.Trim();*/
                    obj_luong.NgayLap1 = tbNgayLap.Text.Trim();
                    LuongBLL luong = new LuongBLL();
                    // string MaSoLuong = tbMaSL.Text.Trim();
                    if (!(luong.Checkluong(tbMaSL.Text.Trim())))
                    {
                        luong.insert(obj_luong);
                        Load_LuongNV();
                    }
                    else
                        MessageBox.Show("ma so luong nhan vien" + manv + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("them bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (query == "sua")
            {
                try
                {
                    LuongEntities obj_luong = new LuongEntities();
                    obj_luong.MaNV1 = tbMa.Text.Trim();
                    obj_luong.MaSL1 = tbMaSL.Text.Trim();
                    obj_luong.SoNgayCong1 = Convert.ToInt32(tbSoNgayCong.Text);
                    obj_luong.PhuCapCV1 = Convert.ToInt32(tbPhuCap.Text);
                    obj_luong.HeSoLuong1 = tbHeSoLuong.Text.Trim();
                    obj_luong.SoGiolamThem1 = Convert.ToInt32(tbGioLamThem.Text);
                    obj_luong.Thuong1 = Convert.ToInt32(tbThuong.Text);
                    obj_luong.TamUng1 = Convert.ToInt32(tbTamUng.Text);
                    /*obj_luong.MaSoLuong1 = tbMaSoLuong.Text.Trim();
                    obj_luong.SoNgayCong1 = tbSoNgayCong.Text.Trim();
                    obj_luong.PhuCapCV1 = tbPhuCap.Text.Trim();
                    obj_luong.SoGiolamThem1 = tbGioLamThem.Text.Trim();
                    obj_luong.HeSoLuong1 = Convert.ToInt32(tbHeSoLuong.Text);
                    obj_luong.Thuong1 = tbThuong.Text.Trim();
                    obj_luong.TamUng1 = tbTamUng.Text.Trim();*/
                    obj_luong.NgayLap1 = tbNgayLap.Text.Trim();
                    LuongBLL luong = new LuongBLL();
                    string MaSoLuong = tbMaSL.Text.Trim();
                    luong.update(obj_luong);
                    Load_LuongNV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("them bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (query == "xoa")
            {
                try
                {
                    string MaSoLuong = tbMaSL.Text.Trim();
                    LuongBLL luong = new LuongBLL();
                    luong.delete(MaSoLuong);
                    Load_LuongNV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("xoa bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void btXoaLuong_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ControllButton_luong(2);
        }

        private void grvLuong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //tbMa.Text = grvLuong["Column1", index].Value.ToString();
            tbMaSoLuong.Text = grvLuong["MaSoLuong", index].Value.ToString();
            tbSoNgayCong.Text = grvLuong["SoNgayCong", index].Value.ToString();
            tbPhuCap.Text = grvLuong["PhuCapCV", index].Value.ToString();
            tbMaSL.Text = grvLuong["MaSoLuong", index].Value.ToString();
            tbGioLamThem.Text = grvLuong["SoGioLamThem", index].Value.ToString();
            tbHeSoLuong.Text = grvLuong["HeSoLuong", index].Value.ToString();
            tbThuong.Text = grvLuong["Thuong", index].Value.ToString();
            tbTamUng.Text = grvLuong["TamUng", index].Value.ToString();
            tbNgayLap.Text = grvLuong["NgayLap", index].Value.ToString();
        }
        private void ControllButton_luong(int type)
        {
            btThemLuong.Visible = type == 1 ? true : false;
            btSualuong.Visible = type == 1 ? true : false;
            btXoaLuong.Visible = type == 1 ? true : false;
            btLuuLuong.Visible = type == 2 ? true : false;
            btHuyLuong.Visible = type == 2 ? true : false;
        }

        #endregion

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
