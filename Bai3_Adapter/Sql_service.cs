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
            init_cnn();
            init_tbKH();
        }

        static void init_cnn()
        {
            cnn.ConnectionString = get_connectionString();
        }


        static void init_tbKH()
        {
            try
            {
                SqlDataAdapter adt = crt_adtKH();
                adt.Fill(tb_KH);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Khởi tạo bảng KhachHang thất bại. Nguyên nhân:\n" + ex.Message);
            }
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
            return tb_KH;
        }


        static private SqlCommand crt_cmdKH()
        {
            return new SqlCommand("Select * from KhachHang", cnn);
        }


        static private SqlDataAdapter crt_adtKH()
        {
            SqlCommand cmd = crt_cmdKH();
            SqlDataAdapter adt = new SqlDataAdapter();

            adt.SelectCommand = cmd;

            return adt;
        }


        static public void upd_tbKH()
        {
            DataTable tb_change = tb_KH.GetChanges();

            if(tb_change == null)
            {
                MessageBox.Show("Dữ liệu chưa thay đổi");
                return;
            }

            SqlDataAdapter adt = crt_adtKH();
            SqlCommandBuilder cmb  = new SqlCommandBuilder(adt);

            adt.Update(tb_KH);
            MessageBox.Show("Đã cập nhập " + tb_change.Rows.Count + " dòng");
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
