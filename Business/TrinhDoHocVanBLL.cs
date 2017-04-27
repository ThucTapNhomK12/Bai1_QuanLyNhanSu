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
    class TrinhDoHocVanBLL
    {
         public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.TrinhDoHocVan";
            result=config.GetData(strQuery);
            return result;
        }
        public int Insert(TrinhDoHocVanEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.TrinhDoHocVan(MaTDHV,TDHV,ChuyenNganh) values('" + obj.Matrinhdohocvan + "','" + obj.Trinhdohocvan + "','" + obj.Chuyennganh + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
        public bool Checktdhv(string Matrinhdohocvan)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.TrinhDoHocVan where MaTDHV='" + Matrinhdohocvan + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(TrinhDoHocVanEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.TrinhDoHocVan set TDHV='"+obj.Trinhdohocvan+"' ,ChuyenNganh='"+obj.Chuyennganh+"' where MaTDHV='"+obj.Matrinhdohocvan+"'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
        //xoa
        public int delete(string Matrinhdohocvan)
        {
            int result = 0;
            string strQuery = "delete from dbo.TrinhDoHocVan where MaTDHV='"+Matrinhdohocvan+"'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
    }
    }
