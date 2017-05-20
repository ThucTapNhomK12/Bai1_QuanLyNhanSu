using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhanSu.DataAccess;
using NhanSu.Entities;
using System.Data.SqlClient;
using System.Data;

namespace NhanSu.Business
{
    class LuongBLL
    {
        public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            //lua chon toan bo cac bang
            string strQuery = "select * from dbo.LuongNhanVien";
            result = config.GetData(strQuery);
            return result;
        }
        //them csdl
        public int insert(LuongEntities obj)
        {
            int result = 0;
            string strQuery = "insert into LuongNhanVien(MaSoLuong,SoNgayCong,PhuCapCV,SoGioLamThem,HeSoLuong,Thuong,TamUng,NgayLap) values ('" + obj.MaSoLuong1 + "','" + obj.SoNgayCong1 + "','" + obj.PhuCapCV1 + "','" + obj.SoGiolamThem1 + "','" + obj.HeSoLuong1 + "','" + obj.Thuong1 + "','" + obj.TamUng1 + "','" + obj.NgayLap1 + "')";
            DataConfig config = new DataConfig();//khoi tao
            result = config.excuteNonquery(strQuery);//thuc thi cau lenh
            return result;//tra ve so ban ghi dc  them
        }
        //check id
        public bool Checkluong(string manv)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.LuongNhanVien where masoluong='" + MaSoLuong + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            //neu dong lon hon 0 thi da ton tai
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(LuongEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.LuongNhanVien set masoluong='" + obj.MaSoLuong1 + "',songaycong='" + obj.SoNgayCong1 + "',Phucapcv='" + obj.PhuCapCV1 + "',sogiolamthem='" + obj.SoGiolamThem1 + "',hesoluong='" + obj.HeSoLuong1 + "',thuong='" + obj.Thuong1 + "',tamung='" + obj.TamUng1 + "',ngaylap='" + obj.NgayLap1 + "'where MaSoLuong='" + obj.MaSL1 + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public int delete(string masoluong)
        {
            int result = 0;
            string strQuery = "delete from dbo.LuongNhanVien where MaSoLuong='" + masoluong + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }


        public string MaSoLuong { get; set; }
    }
}