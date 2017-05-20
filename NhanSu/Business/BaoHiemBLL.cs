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
    class BaoHiemBLL
    {
           public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.BaoHiem";
            result=config.GetData(strQuery);
            return result;
        }
      /*  public DataTable FindItem(string item)
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.BaoHiem where MaChucVu like '%" + item + "%' or TenChucvu '%" + item + "%'";
            result = config.GetData(strQuery);
            return result;
        }*/
        public int Insert(BaoHiemEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.BaoHiem(MaNV,MaSBH,NgayCapSo,NoiCapSo,GhiChu) values('" + obj.Manv + "','" + obj.Masbh + "','" + obj.Songaycap + "','"+obj.Noicapso+"','"+obj.Ghichu+"')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
        public bool Checkbh(string Masbh)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.BaoHiem where MaSBH='" + Masbh + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(BaoHiemEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.BaoHiem set MaNV='"+obj.Manv+"',NgayCapSo='"+obj.Songaycap+"',NoiCapSo='"+obj.Noicapso+"',GhiChu='"+obj.Ghichu+"' where MaSBH='"+obj.Masbh+"'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
        //xoa
        public int delete(string manv)
        {
            int result = 0;
            string strQuery = "delete from dbo.BaoHiem where MaNV='"+manv+"'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);//thucthi
            return result;//tra ve so ban ghi
        }
    }
}
