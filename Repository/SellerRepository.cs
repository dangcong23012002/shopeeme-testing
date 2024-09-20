using ShopeeMe.Tests.Func;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeMe.UnitTests.Repository
{
    public class SellerRepository
    {
        public bool loginSellerAccount(string phone, string password)
        {
            password = Functions.encrypt(password);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LoginAccountSeller";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sSellerPhone", phone);
            cmd.Parameters.AddWithValue ("@sSellerPassword", password);
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool getSellerAccountByID(int sellerID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GetSellerAccountByID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iSellerID", sellerID);
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0)
            {
                return true;
            } else
            { 
                return false; 
            }
        }

        public bool getPasswordSellerAccountByPhone(string phone)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GetPasswordSellerAccountByPhone";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sSellerPhone", phone);
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool checkSellerAccountByIDAndPass(int sellerID, string password)
        {
            password = Functions.encrypt(password);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_CheckSellerAccountByIDAndPass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iSellerID", sellerID);
            cmd.Parameters.AddWithValue ("@sSellerPassword", password);
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0 )
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool changePasswordSellerAccount(int sellerID, string password)
        {
            password = Functions.encrypt(password); 
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ChangePasswordSellerAccount";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iSellerID", sellerID);
            cmd.Parameters.AddWithValue("@sSellerPassword", password);
            Functions.excuteNonQuery(cmd);
            return true;
        }
    }
}
