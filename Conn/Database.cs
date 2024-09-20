using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeMe.Tests.Conn
{
    public class Database
    {
        public static string strConnection = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=db_Shopee;Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(strConnection);
        }
    }
}
