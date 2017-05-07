using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhanSu.DataAccess;
using NhanSu.Entities;

namespace NhanSu.Business
{
    class ChucVuBLL
    {
         //ham getdata
        public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.ChucVu";
            result=config.GetData(strQuery);
            return result;
        }
        public DataTable FindItem(string item)
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.ChucVu where MaChucVu like '%" + item + "%' or TenChucvu '%" + item + "%'";
            result = config.GetData(strQuery);
            return result;
        }
        public int Insert(ChucVuEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.ChucVu(MaChucVu,TenChucVu,PhuCapCV) values('" + obj.Macv + "','" + obj.Tencv + "','" + obj.Phucapcv + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
        public bool Checkid(string macv)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.ChucVu where MaChucVu='" + macv + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(ChucVuEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.ChucVu set TenChucVu='"+obj.Tencv+"',PhuCapCV='"+obj.Phucapcv+"' where MaChucVu='"+obj.Macv+"'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
        //xoa
        public int delete(string macv)
        {
            int result = 0;
            string strQuery = "delete from dbo.ChucVu where MaChucVu='"+macv+"'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
    }
    }

