using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_Command
{
    static internal class Sql_service
    {
        const string DEFAULT_SERVER = "DESKTOP-L72T38U\\SQLEXPRESS";
        const string DEFAULT_DATABASE = "HoaDon";

        static SqlConnection cnn = new SqlConnection();

        static Sql_service() 
        {
            cnn.ConnectionString = get_connectionString();
        }

        static public string get_connectionString()
        {
            string str = "server=" + DEFAULT_SERVER
                       + ";database=" + DEFAULT_DATABASE
                       + ";integrated security=true";

            return str;
        }

        static public SqlCommand get_cmdLoadLv()
        {
            SqlCommand cmd = crt_cmd();
            cmd.CommandText = "Select * from KhachHang";
            return cmd;
        }

        static private SqlCommand crt_cmd()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandTimeout = 60;
            cmd.Connection = cnn;

            return cmd;
        }

        static public void add_KH(float maKH, string tenKH, string diaChi, string SDT)
        {
            string str = "insert into KhachHang (MaKH, TenKH, DCKH, DTKH)"
                       + " values(@MaKH, @TenKH, @DCKH, @DTKH)";

            try
            {
                SqlCommand cmd = crt_cmd();
                cmd.CommandText = str;

                cmd.Parameters.Add("@MaKH", maKH);
                cmd.Parameters.Add("@TenKH", tenKH);
                cmd.Parameters.Add("@DCKH", diaChi);
                cmd.Parameters.Add("@DTKH", SDT);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm dữ liệu thành công");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }

        static public void edit_KH(float maKH_prv, float maKH, string tenKH, string diaChi, string SDT)
        {
            string str = "update KhachHang set "
                       + "MaKH=@MaKH"
                       + ",TenKH=@TenKH"
                       + ",DCKH=@DCKH"
                       + ",DTKH=@DTKH"
                       + " where MaKH=@MaKH_prv";

            try
            {
                SqlCommand cmd = crt_cmd();
                cmd.CommandText = str;

                cmd.Parameters.Add("@MaKH", maKH);
                cmd.Parameters.Add("@TenKH", tenKH);
                cmd.Parameters.Add("@DCKH", diaChi);
                cmd.Parameters.Add("@DTKH", SDT);
                cmd.Parameters.Add("@MaKH_prv", maKH_prv);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa dữ liệu thành công");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Sửa dữ liệu thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }

        static public void rmv_KH(float maKH)
        {
            string str = "delete from KhachHang where MaKH=@MaKH";

            try
            {
                SqlCommand cmd = crt_cmd();

                cmd.CommandText = str;
                cmd.Parameters.Add("@MaKH", maKH);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa dữ liệu thành công");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Xóa dữ liệu thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }

        static public void connect_sql()
        {
            try
            {
                cnn.Close();
                cnn.Open();
                MessageBox.Show("Kết nối sql server thành công");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Kết nối sql server thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }

        static public void disconnect_sql()
        {
            cnn.Close();
        }
    }
}
