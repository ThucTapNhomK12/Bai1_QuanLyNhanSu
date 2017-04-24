using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhanSu.Entities;
using NhanSu.DataAccess;
using System.Data;

namespace NhanSu.Business
{
    class KhenThuongBLL
    {
        //ham getdata get du lieu vao
        public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            //lua chon toan bo cac bang
            string strQuery = "select *from dbo.KhenThuong";
            result = config.GetData(strQuery);
            return result;
        }
        //them csdl
        public int insert(KhenThuongEntities obj)
        {
            int result = 0;
            string strQuery = "Insert into dbo.KhenThuong(MaKT,hinhThucKT,LyDo) values ('" + obj.Makhenthuong + "','" + obj.Hinhthuckhenthuong + "','" + obj.Lydokhenthuong + "')";
            DataConfig config = new DataConfig();//khoi tao
            result = config.excuteNonquery(strQuery);//thuc thi cau lenh
            return result;//tra ve so ban ghi dc  them
        }
        //check id
        public bool Checkkt(string Makhenthuong)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.KhenThuong where MaKT='" + Makhenthuong + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            //neu dong lon hon 0 thi da ton tai
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(KhenThuongEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.KhenThuong set HinhThucKT='" + obj.Hinhthuckhenthuong + "',LyDo='" + obj.Lydokhenthuong + "' where MaKT='" + obj.Makhenthuong + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public int delete(string Makhenthuong)
        {
            int result = 0;
            string strQuery = "delete from dbo.KhenThuong where MaKT='" + Makhenthuong + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }


    }
}
