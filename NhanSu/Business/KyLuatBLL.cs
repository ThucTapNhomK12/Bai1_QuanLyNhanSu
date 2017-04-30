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
    class KyLuatBLL
    {
        //ham getdata get du lieu vao
        public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            //lua chon toan bo cac bang
            string strQuery = "select *from dbo.KyLuat";
            result = config.GetData(strQuery);
            return result;
        }
        //them csdl
        public int insert(KyLuatEntities obj)
        {
            int result = 0;
            string strQuery = "Insert into dbo.KyLuat(MaKl,hinhThucKL,LyDo) values ('" + obj.Makl + "','" + obj.Hinhthuckyluat + "','" + obj.Lydo + "')";
            DataConfig config = new DataConfig();//khoi tao
            result = config.excuteNonquery(strQuery);//thuc thi cau lenh
            return result;//tra ve so ban ghi dc  them
        }
        //check id
        public bool Checkkl(string Makl)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.KyLuat where MaKl='" + Makl + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            //neu dong lon hon 0 thi da ton tai
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(KyLuatEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.KyLuat set HinhThucKL='" + obj.Hinhthuckyluat + "',LyDo='" + obj.Lydo + "' where MaKl='" + obj.Makl + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public int delete(string Makl)
        {
            int result = 0;
            string strQuery = "delete from dbo.KyLuat where MaKl='" + Makl + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }


        internal void Insert(KyLuatEntities kyluatenti)
        {
            throw new NotImplementedException();
        }
    }
    }
