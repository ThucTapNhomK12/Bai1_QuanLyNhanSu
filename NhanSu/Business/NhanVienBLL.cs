using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhanSu.DataAccess;
using NhanSu.Entities;
using System.Data;

namespace NhanSu.Business
{
    class NhanVienBLL
    {
        //ham getdata get du lieu vao
        public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            //lua chon toan bo cac bang
            //string strQuery = "select  dbo.NhanVien.*,dbo.PhongBan.TenPhongBan as TenPB*fromdbo.NhanVien,dbo.PhongBan where dbo.NhanVen.PhongBanMa=dbo.PhongBan.MaPhongBan";
            string strQuery = "select * from dbo.NhanVien";
            result = config.GetData(strQuery);
            return result;
        }
        public DataTable Finditem(string item)
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.NhanVien where MaNV like '%" + item + "%' or HoTen like '%" + item + "%' or CMTND like '%" + item + "%'";
            result = config.GetData(strQuery);
            return result;
        }
        //them csdl
        public int insert(NhanVienEntities obj)
        {
            int result = 0;
            string strQuery = "insert into NhanVien(MaNV,HoTen,NgaySinh,GioiTinh,DiaChi,DanToc,TonGiao,CMTND,TinhTrangHonNhan,SoDienThoai,GhiChu,MaPhongBan,MaChucVu,MaTDHV,NgoaiNgu,MaHD,MaSBH,MaKT,MaKL) values ('" + obj.Manv + "','" + obj.Hoten + "','" + obj.Ngaysinh + "','" + obj.Gioitinh + "','" + obj.Diachi + "','" + obj.Dantoc + "','" + obj.Tongiao + "','" + obj.Cmtnd + "','" + obj.Tinhtranghonnhan + "','" + obj.Sodienthoai + "','" + obj.Ghichu + "','" + obj.Maphongban + "','" + obj.Machucvu + "','" + obj.Matrinhdo + "','" + obj.Ngoaingu + "','" + obj.Mahopdong + "','" + obj.Masobaohiem + "','" + obj.Makhenthuong + "','" + obj.Makyluat + "')";
            DataConfig config = new DataConfig();//khoi tao
            result = config.excuteNonquery(strQuery);//thuc thi cau lenh
            return result;//tra ve so ban ghi dc  them
        }
        //check id
        public bool CheckID(string manv)
        {
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.NhanVien where MaNV=" + manv ;
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            //neu dong lon hon 0 thi da ton tai
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(NhanVienEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.NhanVien set hoten=" + obj.Hoten + ",ngaysinh=" + obj.Ngaysinh + ",gioitinh=" + obj.Gioitinh + ",diachi=" + obj.Diachi + ",dantoc=" + obj.Dantoc + ",tongiao=" + obj.Tongiao + ",cmtnd=" + obj.Cmtnd + ",honnhan=" + obj.Tinhtranghonnhan + ",sdt=" + obj.Sodienthoai + ",ghichu=" + obj.Ghichu + ",maphongban=" + obj.Maphongban + "'machucvu='" + obj.Machucvu + ",matrinhdo=" + obj.Matrinhdo + ",ngoaingu=" + obj.Ngoaingu + ",mahopdong=" + obj.Mahopdong + ",baohiem=" + obj.Masobaohiem + ",khenthuong=" + obj.Makhenthuong + ",kyluat=" + obj.Makyluat + "where manv=" + obj.Manv;
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public int delete(string manv)
        {
            int result = 0;
            string strQuery = "delete from dbo.NhanVien where manv='" + manv + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
    }
}
