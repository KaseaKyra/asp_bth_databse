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
    public partial class frmSinhVien : System.Web.UI.Page
    {
        ClsConnect clsCon = new ClsConnect();
        SqlCommand sqlCommand;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                clsCon.openDB();

                // load dl bảng sinh viên
                string strSql = "select Masv, Tensv, Khoa, Email from tbl_sinhvien";
                sqlCommand = new SqlCommand(strSql, clsCon.con);
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
                        + "</td><td>"
                        + re.GetValue(2).ToString()
                        + "</td><td>"
                        + re.GetValue(3).ToString()
                        + "</td><td><a href=\"frmSinhVienChiTiet.aspx?msv="
                        + re.GetValue(0).ToString()
                        + " \">chi tiết</a></td></tr>";
                }
                re.Close();
                ltrKetQua.Text = st_kq;

            }
            catch (Exception ex)
            {
                Response.Write("Lối: " + ex);
            }
            finally
            {
                clsCon.closeDB();
            }
        }
    }
}