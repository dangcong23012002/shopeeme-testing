using ShopeeMe.Tests.Conn;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ShopeeMe.Tests.Func
{
    public class Functions
    {
        public static DataTable getData(SqlCommand cmd)
        {
            DataTable table = new DataTable();
            SqlConnection conn = Database.getConnection(); ;
            conn.Open();
            cmd.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            conn.Close();
            return table;
        }

        public static void excuteNonQuery(SqlCommand cmd)
        {
            if (cmd.Connection != null)
            {
                cmd.ExecuteNonQuery();
            } else
            {
                SqlConnection conn = Database.getConnection();
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
        }

        // Phương thức giải mã
        public static string decrypt(string encrypted)
        {
            string hash = "cong@gmail.com";
            byte[] data = Convert.FromBase64String(encrypted);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider();
            tripDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripDES.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripDES.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            return UTF8Encoding.UTF8.GetString(result);
        }

        // Phương thức mã hoá
        public static string encrypt(string decryted)
        {
            string hash = "cong@gmail.com";
            byte[] data = UTF8Encoding.UTF8.GetBytes(decryted);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider();
            tripDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripDES.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripDES.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);
        }
    }
}
