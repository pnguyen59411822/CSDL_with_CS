using System;
using System.Collections.Generic;
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
