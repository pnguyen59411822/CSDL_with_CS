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

        static public void connect_sql()
        {
            try
            {
                cnn.Open();
                MessageBox.Show("Kết nối sql server thành công");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Kết nối sql server thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }
    }
}
