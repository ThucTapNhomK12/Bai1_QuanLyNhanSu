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
            Load_LuongNV();
            Load_ChucVu();
            Load_PhongBan();
            Load_HopDong();
            Load_kyluat();
            Load_khenthuong();
            Load_trinhdohocvan();
            Load_baohiem();
            Load_timkiem();
            ControllButton(1);
            ControllButton_luong(1);
            ControllButton_chucvu(1);
            ControllButton_phongban(1);
            ControllButton_hopdong(1);
            ControllButton_kyluat(1);
            ControllButton_khenthuong(1);
            ControllButton_trinhdo(1);
            ControllButton_baohiem(1);
        }
        private void Load_Data()
        {
            NhanVienBLL nvBLL = new NhanVienBLL();
            grvNhanVien.DataSource = nvBLL.GetData();
            //fill combobox
            LuongBLL luong = new LuongBLL();
            PhongBanBLL phongbanbll = new PhongBanBLL();
            cbbMaPhongBan.DataSource = phongbanbll.GetData();
            cbbMaPhongBan.DisplayMember = "TenPhongBan";
            cbbMaPhongBan.ValueMember = "MaPhongBan";
            ChucVuBLL chucvubll = new ChucVuBLL();
            cbbMaChucVu.DataSource = chucvubll.GetData();
            cbbMaChucVu.DisplayMember = "TenChucVu";
            cbbMaChucVu.ValueMember = "MaChucVu";
            KyLuatBLL kyluatbll = new KyLuatBLL();
            cbbMaKyLuat.DataSource = kyluatbll.GetData();
            cbbMaKyLuat.DisplayMember = "HinhThucKL";
            cbbMaKyLuat.ValueMember = "MaKl";
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
                    obj_nv.Cmtnd = tbCMTND.Text.Trim();
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
                    Console.Write(obj_nv.Hoten);
                    obj_nv.Ngaysinh = tbNamSinh.Text.Trim();
                    obj_nv.Gioitinh = tbGioiTinh.Text.Trim();
                    obj_nv.DiaChi = tbDiaChi.Text.Trim();
                    obj_nv.Dantoc = tbDanToc.Text.Trim();
                    obj_nv.TonGiao = tbTonGiao.Text.Trim();
                    obj_nv.Cmtnd = tbCMTND.Text.Trim();
                    obj_nv.TinhTrangHonNhan = tbHonNhan.Text.Trim();
                    obj_nv.SoDienThoai = tbSoDienThoai.Text.Trim();
                    obj_nv.GhiChu = tbGhiChu.Text.Trim();
                   // obj_nv.MaSoLuong = tbMaSoLuong.Text.Trim();
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
        #region"ChucVu"
        private void Load_ChucVu()
        {
            ChucVuBLL chucvubll = new ChucVuBLL();
            grvChucVu.DataSource = chucvubll.GetData();
        }
        private void btTemCV_Click(object sender, EventArgs e)
        {
            Query = "them";
            ControllButton_chucvu(2);
            tbMaChucVu.Text = "";
            tbTenChucVu.Text = "";
            tbPhuCapChucVu.Text = "";
        }
        private void Excute_chucvu(string querycv)
        {
            if (querycv == "them")
            {
                try
                {
                    //khoi tao doi tuong
                    ChucVuEntities chucvuenti = new ChucVuEntities();
                    chucvuenti.Macv = tbMaChucVu.Text.Trim();
                    chucvuenti.Tencv = tbTenChucVu.Text.Trim();
                    chucvuenti.Phucapcv = tbPhuCapChucVu.Text.Trim();
                    ChucVuBLL chucvubll = new ChucVuBLL();
                    if (!(chucvubll.Checkid(tbMaChucVu.Text.Trim())))
                    {
                        chucvubll.Insert(chucvuenti);
                        Load_ChucVu();
                    }
                    else
                        MessageBox.Show("Ma lop:" + macv + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("them bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            if (querycv == "sua")
            {
                try
                {
                    //khoi tao doi tuong
                    ChucVuEntities chucvuenti = new ChucVuEntities();
                    chucvuenti.Macv = tbMaChucVu.Text.Trim();
                    chucvuenti.Tencv = tbTenChucVu.Text.Trim();
                    chucvuenti.Phucapcv = tbPhuCapChucVu.Text.Trim();
                    ChucVuBLL chucvubll = new ChucVuBLL();
                    chucvubll.update(chucvuenti);
                    Load_ChucVu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (querycv == "xoa")
            {
                try
                {
                    string macv = tbMaChucVu.Text.Trim();
                    ChucVuBLL chucvubll = new ChucVuBLL();
                    chucvubll.delete(macv);
                    Load_ChucVu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btSuaCV_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ControllButton_chucvu(2);
            tbMaChucVu.ReadOnly = true;
        }

        private void btXoaCV_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ControllButton_chucvu(2);
        }

        private void btLuuCV_Click(object sender, EventArgs e)
        {
            Excute_chucvu(Query);
            ControllButton_chucvu(1);
        }

        private void btHuyCV_Click(object sender, EventArgs e)
        {
            ControllButton_chucvu(1);
        }

        private void grvChucVu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbMaChucVu.Text = grvChucVu["MaChucVu", index].Value.ToString();
            tbTenChucVu.Text = grvChucVu["TenChucVu", index].Value.ToString();
            tbPhuCapChucVu.Text = grvChucVu["PhuCap", index].Value.ToString();
        }
        private void ControllButton_chucvu(int type)
        {
            btTemCV.Visible = type == 1 ? true : false;
            btSuaCV.Visible = type == 1 ? true : false;
            btXoaCV.Visible = type == 1 ? true : false;
            btLuuCV.Visible = type == 2 ? true : false;
            btHuyCV.Visible = type == 2 ? true : false;
        }
#endregion
        #region"phongban"
        private void Load_PhongBan()
        {
            PhongBanBLL phongbanbll = new PhongBanBLL();
            grvPhongBan.DataSource = phongbanbll.GetData();
        }

        private void btThemPB_Click(object sender, EventArgs e)
        {
            Query = "them";
            ControllButton_phongban(2);
            tbMaPhongBan.Text = "";
            tbTenPhongBan.Text = "";
            tbSDTPhongBan.Text = "";
        }
        private void Excute_phongban(string querypb)
        {
            if (querypb == "them")
            {
                try
                {
                    //khoi tao doi tuong
                    PhongBanEntities phongbanenti = new PhongBanEntities();
                    phongbanenti.Mapb = tbMaPhongBan.Text.Trim();
                    phongbanenti.Tenpb = tbTenPhongBan.Text.Trim();
                    phongbanenti.Sdt = tbSDTPhongBan.Text.Trim();
                    PhongBanBLL phongbanbll = new PhongBanBLL();
                    if (!(phongbanbll.Checkpb(tbMaPhongBan.Text.Trim())))
                    {
                        phongbanbll.Insert(phongbanenti);
                        Load_PhongBan();
                    }
                    else
                        MessageBox.Show("Ma phong ban:" + MaPhongBan+ "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("them bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            if (querypb == "sua")
            {
                try
                {
                    //khoi tao doi tuong
                    PhongBanEntities phongbanenti = new PhongBanEntities();
                    phongbanenti.Mapb = tbMaPhongBan.Text.Trim();
                    phongbanenti.Tenpb = tbTenPhongBan.Text.Trim();
                    phongbanenti.Sdt = tbSDTPhongBan.Text.Trim();
                    PhongBanBLL phongbanbll = new PhongBanBLL();
                    phongbanbll.update(phongbanenti);
                    Load_PhongBan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (querypb == "xoa")
            {
                try
                {
                    string Mapb = tbMaPhongBan.Text.Trim();
                    PhongBanBLL phongbanbll = new PhongBanBLL();
                    phongbanbll.delete(Mapb);
                    Load_PhongBan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btSuaPB_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ControllButton_phongban(2);
            tbMaPhongBan.ReadOnly = true;
        }

        private void btXoaPB_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ControllButton_phongban(2);
        }
        private void grvPhongBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbMaPhongBan.Text = grvPhongBan["MaPhongBan", index].Value.ToString();
            tbTenPhongBan.Text = grvPhongBan["TenPhongBan", index].Value.ToString();
            tbSDTPhongBan.Text = grvPhongBan["sdt", index].Value.ToString();
        }
        private void btLuuPB_Click(object sender, EventArgs e)
        {
            Excute_phongban(Query);
            ControllButton_phongban(1);
        }

        private void btHuyPB_Click(object sender, EventArgs e)
        {
            ControllButton_phongban(1);
        }
        private void ControllButton_phongban(int type)
        {
            btThemPB.Visible = type == 1 ? true : false;
            btSuaPB.Visible = type == 1 ? true : false;
            btXoaPB.Visible = type == 1 ? true : false;
            btLuuPB.Visible = type == 2 ? true : false;
            btHuyPB.Visible = type == 2 ? true : false;
        }
        #endregion
        #region"hopdong"
        private void Load_HopDong()
        {
            HopDongBLL hopdongbll = new HopDongBLL();
            grvHopDong.DataSource = hopdongbll.GetData();
        }
        private void btThemHD_Click(object sender, EventArgs e)
        {
            Query = "them";
            ControllButton_hopdong(2);
            tbHopDong.Text = "";
            tbTenHD.Text = "";
            tbNgayKiKet.Text = "";
            tbNgayHetHan.Text = "";
            tbHopDong.ReadOnly = false;
        }
        private void Excute_hopdong(string queryhd)
        {
            if (queryhd == "them")
            {
                try
                {
                    HopDongEntities hopdongenti = new HopDongEntities();
                    hopdongenti.Mahd = tbHopDong.Text.Trim();
                    hopdongenti.Tenhd = tbTenHD.Text.Trim();
                    hopdongenti.Ngaykiket = tbNgayKiKet.Text.Trim();
                    hopdongenti.Ngayhethan = tbNgayHetHan.Text.Trim();
                    HopDongBLL hopdongbll = new HopDongBLL();
                    if (!(hopdongbll.Checkhd(tbHopDong.Text.Trim())))
                    {
                        hopdongbll.Insert(hopdongenti);
                        Load_HopDong();
                    }
                    else
                        MessageBox.Show("Ma hop dong" + mahd + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("them bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (queryhd == "sua")
            {
                try
                {
                    HopDongEntities hopdongenti = new HopDongEntities();
                    hopdongenti.Mahd = tbHopDong.Text.Trim();
                    hopdongenti.Tenhd = tbTenHD.Text.Trim();
                    hopdongenti.Ngaykiket = tbNgayKiKet.Text.Trim();
                    hopdongenti.Ngayhethan = tbNgayHetHan.Text.Trim();
                    HopDongBLL hopdongbll = new HopDongBLL();
                    hopdongbll.update(hopdongenti);
                    Load_HopDong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (queryhd == "xoa")
            {
                try
                {
                    string mahd = tbHopDong.Text.Trim();
                    HopDongBLL hopdongbll = new HopDongBLL();
                    hopdongbll.delete(mahd);
                    Load_HopDong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btSuaHD_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ControllButton_hopdong(2);
            tbHopDong.ReadOnly = true;
        }

        private void btXoaHD_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ControllButton_hopdong(2);
        }
        private void grvHopDong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbHopDong.Text = grvHopDong["MaHopDong", index].Value.ToString();
            tbTenHD.Text = grvHopDong["TenHD", index].Value.ToString();
            tbNgayKiKet.Text = grvHopDong["NgayKiKet", index].Value.ToString();
            tbNgayHetHan.Text = grvHopDong["NgayHetHan", index].Value.ToString();
        }
        private void btLuuHD_Click(object sender, EventArgs e)
        {
            Excute_hopdong(Query);
            ControllButton_hopdong(1);
        }

        private void btHuyHD_Click(object sender, EventArgs e)
        {
            ControllButton_hopdong(1);
        }
        private void ControllButton_hopdong(int type)
        {
            btThemHD.Visible = type == 1 ? true : false;
            btSuaHD.Visible = type == 1 ? true : false;
            btXoaHD.Visible = type == 1 ? true : false;
            btLuuHD.Visible = type == 2 ? true : false;
            btHuyHD.Visible = type == 2 ? true : false;
        }
        #endregion
        #region"kyLuat"
        private void Load_kyluat()
        {
            KyLuatBLL kyluatbll = new KyLuatBLL();
            grvKyLuat.DataSource = kyluatbll.GetData();
        }
        private void btThemKL_Click(object sender, EventArgs e)
        {
            Query = "them";
            ControllButton_kyluat(2);
            tbMaKL.Text = "";
            tbHinhThucKL.Text = "";
            tbLyDoKL.Text = "";
            tbMaKL.ReadOnly = false;
        }
        private void Excute_kyluat(string querykl)
        {
            if (querykl == "them")
            {
                try
                {
                    //khoi tao doi tuong
                    KyLuatEntities kyluatenti = new KyLuatEntities();
                    kyluatenti.Makl = tbMaKL.Text.Trim();
                    kyluatenti.Hinhthuckyluat = tbHinhThucKL.Text.Trim();
                    kyluatenti.Lydo = tbLyDo.Text.Trim();
                    KyLuatBLL kyluatbll = new KyLuatBLL();
                    if (!(kyluatbll.Checkkl(tbMaKL.Text.Trim())))
                    {
                        kyluatbll.insert(kyluatenti);
                        Load_kyluat();
                    }
                    else
                        MessageBox.Show("Ma ky luat:" + makl + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("them bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            if (querykl == "sua")
            {
                try
                {
                    //khoi tao doi tuong
                    KyLuatEntities kyluatenti = new KyLuatEntities();
                    kyluatenti.Makl = tbMaKL.Text.Trim();
                    kyluatenti.Hinhthuckyluat = tbHinhThucKL.Text.Trim();
                    kyluatenti.Lydo = tbLyDoKL.Text.Trim();
                    KyLuatBLL kyluatbll = new KyLuatBLL();
                    kyluatbll.update(kyluatenti);
                    Load_kyluat();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (querykl == "xoa")
            {
                try
                {
                    string makl = tbMaKL.Text.Trim();
                    KyLuatBLL kyluatbll = new KyLuatBLL();
                    kyluatbll.delete(makl);
                    Load_kyluat();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btSuaKL_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ControllButton_kyluat(2);
            tbMaKL.ReadOnly = true;
        }

        private void btXoaKL_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ControllButton_kyluat(2);
        }

        private void btLuuKL_Click(object sender, EventArgs e)
        {
            Excute_kyluat(Query);
            ControllButton_kyluat(1);
        }

        private void btHuyKL_Click(object sender, EventArgs e)
        {
            ControllButton_kyluat(1);
        }
        private void ControllButton_kyluat(int type)
        {
            btThemKL.Visible = type == 1 ? true : false;
            btSuaKL.Visible = type == 1 ? true : false;
            btXoaKL.Visible = type == 1 ? true : false;
            btLuuKL.Visible = type == 2 ? true : false;
            btHuyKL.Visible = type == 2 ? true : false;
        }

        private void grvKyLuat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbMaKL.Text = grvKyLuat["Column2", index].Value.ToString();
            tbHinhThucKL.Text = grvKyLuat["HinhThucKL", index].Value.ToString();
            tbLyDoKL.Text = grvKyLuat["LyDo", index].Value.ToString();
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
                        MessageBox.Show("Ma trinh do hoc van:"+ Matrinhdohocvan+ "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        #region"baohiem"
        private void Load_baohiem()
        {
            BaoHiemBLL baohiembll = new BaoHiemBLL();
            grvBaoHiem.DataSource = baohiembll.GetData();
        }
        private void btThemBH_Click(object sender, EventArgs e)
        {
            Query = "them";
            ControllButton_baohiem(2);
            tbMaBH.Text = "";
            tbNV.Text = "";
            tbNgayCap.Text = "";
            tbNoiCap.Text = "";
            rtbGhiChu.Text="";
        }
        private void Excute_baohiem(string querybh)
        {
            if (querybh == "them")
            {
                try
                {
                    BaoHiemEntities baohiementi = new BaoHiemEntities();
                    baohiementi.Manv = tbNV.Text.Trim();
                    baohiementi.Masbh = tbMaBH.Text.Trim();
                    baohiementi.Songaycap = tbNgayCap.Text.Trim();
                    baohiementi.Noicapso = tbNoiCap.Text.Trim();
                    baohiementi.Ghichu = rtbGhiChu.Text.Trim();
                    BaoHiemBLL baohiembll = new BaoHiemBLL();
                    if (!(baohiembll.Checkbh(tbMaBH.Text.Trim())))
                    {
                        baohiembll.Insert(baohiementi);
                        Load_baohiem();
                    }
                    else
                        MessageBox.Show("ma bao hiem" + mabaohiem + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("them bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (querybh == "sua")
            {
                try
                {
                    BaoHiemEntities baohiementi = new BaoHiemEntities();
                    baohiementi.Manv = tbNV.Text.Trim();
                    baohiementi.Masbh = tbMaBH.Text.Trim();
                    baohiementi.Songaycap = tbNgayCap.Text.Trim();
                    baohiementi.Noicapso = tbNoiCap.Text.Trim();
                    baohiementi.Ghichu = rtbGhiChu.Text.Trim();
                    BaoHiemBLL baohiembll = new BaoHiemBLL();
                    baohiembll.update(baohiementi);
                    Load_baohiem();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi:" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (querybh == "xoa")
            {
                try
                {
                    string masbh = tbBaoHiem.Text.Trim();
                    BaoHiemBLL baohiembll = new BaoHiemBLL();
                    baohiembll.delete(masbh);
                    Load_baohiem();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("xoa bi loi" +ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btSuaBH_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ControllButton_baohiem(2);
            tbBaoHiem.ReadOnly = true;
        }

        private void btXoaBH_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ControllButton_baohiem(2);
        }

        private void btLuuBH_Click(object sender, EventArgs e)
        {
            Excute_baohiem(Query);
            ControllButton_baohiem(1);
        }

        private void btHuyBH_Click(object sender, EventArgs e)
        {
            ControllButton_baohiem(1);
        }

        private void grvBaoHiem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbNV.Text = grvBaoHiem["Column5", index].Value.ToString();
            tbMaBH.Text = grvBaoHiem["MaSBH", index].Value.ToString();
            tbNgayCap.Text = grvBaoHiem["NgayCapSo", index].Value.ToString();
            tbNoiCap.Text = grvBaoHiem["NoiCapSo", index].Value.ToString();
            rtbGhiChu.Text = grvBaoHiem["Column6", index].Value.ToString();
        }
        private void ControllButton_baohiem(int type)
        {
            btThemBH.Visible = type == 1 ? true : false;
            btSuaBH.Visible = type == 1 ? true : false;
            btXoaBH.Visible = type == 1 ? true : false;
            btLuuBH.Visible = type == 2 ? true : false;
            btHuyBH.Visible = type == 2 ? true : false;
        }
        #endregion
        #region"TimKiem"
        private void Load_timkiem()
        {
            NhanVienBLL nvBLL = new NhanVienBLL();
            grvTimKiem.DataSource = nvBLL.GetData();
        }
        private void rdbMaNV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMaNV.Checked == true)
            {
                tbtimMaNV.Enabled = true;
                tbtimHoTen.Enabled = false;
                tbtimCMND.Enabled = false;
            }
        }

        private void rdbTenNV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTenNV.Checked == true)
            {
                tbtimMaNV.Enabled = false;
                tbtimHoTen.Enabled = true;
                tbtimCMND.Enabled = false;
            }

        }

        private void rdbSoCMND_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSoCMND.Checked == true)
            {
                tbtimMaNV.Enabled = false;
                tbtimHoTen.Enabled = false;
                tbtimCMND.Enabled = true;
            }
        }

        private void tbtimMaNV_TextChanged(object sender, EventArgs e)
        {
            string _item = tbtimMaNV.Text.Trim();
            NhanVienBLL nvBLL = new NhanVienBLL();
            grvTimKiem.DataSource= nvBLL.Finditem(_item);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (rdbMaNV.Checked == true)
            {
                string _item = tbtimMaNV.Text.Trim();
                NhanVienBLL nvBLL = new NhanVienBLL();
                grvTimKiem.DataSource = nvBLL.Finditem(_item);
            }
            if (rdbTenNV.Checked == true)
            {
                string _item = tbtimHoTen.Text.Trim();
                NhanVienBLL nvBLL = new NhanVienBLL();
                grvTimKiem.DataSource = nvBLL.Finditem(_item);
            }
            if (rdbSoCMND.Checked == true)
            {
                string _item = tbtimCMND.Text.Trim();
                NhanVienBLL nvBLL = new NhanVienBLL();
                grvTimKiem.DataSource = nvBLL.Finditem(_item);
            }
        }

        private void tbtimHoTen_TextChanged(object sender, EventArgs e)
        {
            string _item = tbtimHoTen.Text.Trim();
            NhanVienBLL nvBLL = new NhanVienBLL();
            grvTimKiem.DataSource = nvBLL.Finditem(_item);
        }

        private void tbtimCMND_TextChanged(object sender, EventArgs e)
        {
            string _item = tbtimCMND.Text.Trim();
            NhanVienBLL nvBLL=new NhanVienBLL();
            grvTimKiem.DataSource=nvBLL.Finditem(_item);
        }
        #endregion
        #region"BaoCao"
        private void Load_Baocao()
        {
            NhanVienBLL nvBLL = new NhanVienBLL();
            grvBaoCao.DataSource = nvBLL.GetData();
        }
        private void Load_Baocaoluong()
        {
            LuongBLL luong = new LuongBLL();
            grvBaoCao.DataSource = luong.GetData();
        }
        private void btDanhSachNV_Click(object sender, EventArgs e)
        {
            Load_Baocao();
        }

        private void btLuongNV_Click(object sender, EventArgs e)
        {
            Load_Baocaoluong();
        }
        #endregion
    }
 }
