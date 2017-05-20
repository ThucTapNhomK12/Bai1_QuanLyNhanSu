using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using NhanSu.DataAccess;
using NhanSu.Entities;

namespace NhanSu.Business
{
    class NguoiDungBLL
    {
        public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.NguoiDung";
            result = config.GetData(strQuery);
            return result;
        }
        public bool DangNhap(string username, string pass)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select * from NguoiDung where username='" + username + "'and pass='" + pass + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count == 1)
                return true;
            return false;
        }
        public int update(NguoiDungEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.NguoiDung set pass='" + obj.Pass + "' where username='" + obj.Username + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
    }
}