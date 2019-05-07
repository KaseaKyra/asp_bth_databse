using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BTH_Database.AllClass;

namespace BTH_Database
{
    public partial class frmHome : System.Web.UI.Page
    {
        ClsConnect clsCon = new ClsConnect();
        SqlCommand sqlCommand;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                clsCon.openDB();
                //Response.Write("Ket noi sql thanh cong");

                string strSql = "select count(Masv) from tbl_sinhvien";

                //sqlCommand.Connection = clsCon.con;
                //sqlCommand.CommandText = strSql;

                sqlCommand = new SqlCommand(strSql, clsCon.con);
                //sqlCommand = CommandType.StoredProcedure("");

                int soSv = (int)sqlCommand.ExecuteScalar();
                lblSoSv.Text = soSv.ToString();

                // thống kê đồ án tốt nghiệp theo điểm
                //string diemDa1 = "select count(Msv) from tbl_doan where Diem <= 7";
                //string diemDa2 = "select count(Msv) from tbl_doan where Diem between 7.1 and 8.0";
                //string diemDa3 = "select count(Msv) from tbl_doan where Diem between 8.1 and 9.0";
                //string diemDa4 = "select count(Msv) from tbl_doan where Diem between 9.1 and 10.0";

                //SqlCommand sqlCommand1 = new SqlCommand(diemDa1, clsCon.con);
                //SqlCommand sqlCommand2 = new SqlCommand(diemDa2, clsCon.con);
                //SqlCommand sqlCommand3 = new SqlCommand(diemDa3, clsCon.con);
                //SqlCommand sqlCommand4 = new SqlCommand(diemDa4, clsCon.con);

                //lblDiemDa1.Text = ((int)sqlCommand1.ExecuteScalar()).ToString();
                //lblDiemDa2.Text = ((int)sqlCommand2.ExecuteScalar()).ToString();
                //lblDiemDa3.Text = ((int)sqlCommand3.ExecuteScalar()).ToString();
                //lblDiemDa4.Text = ((int)sqlCommand4.ExecuteScalar()).ToString();

                string sqlChuyenNganh = "select cn.Tencn as N'Chuyên ngành', COUNT(sv.Masv) as N'Số sinh viên' " +
                    "from tbl_chuyennganh as cn inner join tbl_sinhvien as sv " +
                    "on cn.Macn = sv.Chuyennganh " +
                    "group by cn.Tencn";
                sqlCommand = new SqlCommand(sqlChuyenNganh, clsCon.con);
                SqlDataReader re = sqlCommand.ExecuteReader();
                string st_kq = "";
                int dem = 0;
                while (re.Read())
                {
                    dem += 1;
                    st_kq += "<tr><td>"
                        + dem
                        + "</td><td>"
                        + re.GetValue(0).ToString()
                        + "</td><td>"
                        + re.GetValue(1).ToString()
                        + "</td></tr>";
                }
                re.Close();
                ltrKetQua.Text = st_kq;
            }
            catch (Exception ex)
            {
                Response.Write("Loi: " + ex);
            }
            finally
            {
                clsCon.closeDB();
            }
        }
    }
}