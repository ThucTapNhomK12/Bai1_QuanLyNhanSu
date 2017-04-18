using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace NhanSu.DataAccess
{
    class DataConfig
    {
        private SqlConnection conn; //khai bao bien connec
        public string strConnec = @"Data Source=ADMIM;Initial Catalog=QLNhanSu;Integrated Security=True";//chuoi ket noi
        //khoi tao mac dinh
        public DataConfig()
        {
            connect();
        }
        public void connect()
        {
            try
            {
                conn = new SqlConnection(strConnec);//khoi tao connect
                conn.Open();//mo ket noi
                if (conn.State == ConnectionState.Open)//neu ket noi dang mo thi ta dong
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ket noi loi" + ex.Message.ToString());
            }
        }
        //ham getdata
        public DataTable GetData(string strSql)
        {
            DataTable result = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            da.Fill(result);
            return result;
        }
        //them sua xoa
        public int excuteNonquery(string sql)
        {
            int result = 0;
            if (conn.State == ConnectionState.Closed)
                conn.Open();//mo ket noi
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;//cau lenh truy van
            result = cmd.ExecuteNonQuery();
            return result;
        }
        //tra ve mot doi tuong nao do
        public object exeCuteScalarQuery(string sql)
        {
            object result = 0;
            if (conn.State == ConnectionState.Closed)
                conn.Open();//mo ket noi
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;//cau lenh truy van
            result = cmd.ExecuteScalar();
            return result;//chuyen kieu khi su dung object
        }
    }
}
