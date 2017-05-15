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
    class PhongBanBLL
    {
        public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.PhongBan";
            result = config.GetData(strQuery);
            return result;
        }
        public int Insert(PhongBanEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.PhongBan(MaPhongBan,TenPhongBan,SoDienThoai) values('" + obj.Mapb + "','" + obj.Tenpb + "','" + obj.Sdt + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
        public bool Checkpb(string Mapb)
        {         
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.PhongBan where MaPhongBan='" + Mapb + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(PhongBanEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.PhongBan set TenPhongBan='" + obj.Tenpb + "', SoDienThoai='" + obj.Sdt + "' where MaPhongBan='" + obj.Mapb + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
        //xoa
       

    }
}