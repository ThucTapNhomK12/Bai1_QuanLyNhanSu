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
    class HopDongBLL
    {
         public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.HopDong";
            result=config.GetData(strQuery);
            return result;
        }
        public int Insert(HopDongEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.HopDong(MaHD,TenHD,NgayKiKet,NgayHetHan) values('" + obj.Mahd + "','" + obj.Tenhd + "','" + obj.Ngaykiket + "','"+obj.Ngayhethan+"')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
        public bool Checkhd(string Mahd)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.ChucVu where MaHD='" + Mahd + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(HopDongEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.HopDong set TenHD='"+obj.Tenhd+"',NgayKiKet='"+obj.Ngaykiket+"',NgayHetHan='"+obj.Ngayhethan+"' where MaHD='"+obj.Mahd+"'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
        //xoa
        public int delete(string Mahd)
        {
            int result = 0;
            string strQuery = "delete from dbo.HopDong where MaHD='"+Mahd+"'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
    }
    }

