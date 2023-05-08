using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_Adapter
{
    static internal class Sql_service
    {
        static private SqlConnection cnn = new SqlConnection();
        static private DataTable tb_KH = new DataTable();


        static Sql_service()
        {
            cnn.ConnectionString = get_connectionString();
        }


        static private String get_connectionString()
        {
            const String DEFAULT_SERVER = "DESKTOP-L72T38U\\SQLEXPRESS";
            const String DEFAULT_DATABASE = "HoaDon";

            String str = "Server=" + DEFAULT_SERVER
                       + ";database=" + DEFAULT_DATABASE
                       + ";integrated security=true"
                       ;

            return str;
        }


        static public DataTable get_tbKH()
        {
            DataTable tb = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("Select * from KhachHang", cnn);
                SqlDataAdapter adt = new SqlDataAdapter();

                adt.SelectCommand = cmd;
                adt.Fill(tb);
            }

            catch(Exception ex)
            {
                MessageBox.Show("Lấy data của bảng KhachHang thất bại. Nguyên nhân:\n" + ex.Message);
            }

            return tb;
        }


        static public void connect_sql()
        {
            try
            {
                cnn.Close();
                cnn.Open();
                // MessageBox.Show("Kết nối sql server thành công");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Kết nối sql server thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }


        static public void disconnect_sql()
        {
            try
            {
                cnn.Close();
                // MessageBox.Show("Ngắt kết nối sql server thành công");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Kết nối sql server thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }
    }
}
