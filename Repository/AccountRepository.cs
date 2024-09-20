using ShopeeMe.Tests.Func;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeMe.Tests.Repository
{
    public class AccountRepository
    {
        public bool loginAccount(string email, string password)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LoginEmailAndPassword";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sEmail", email);
            cmd.Parameters.AddWithValue("@sPassword", password);
            DataTable table =  Functions.getData(cmd);
            if (table.Rows.Count > 0)
            {
                return true;
            } else
            { 
                return false; 
            }
         
        }

        public bool checkLoginAccountByUserID(int userID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_CheckUserLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iUserID", userID);
            DataTable table = Functions.getData(cmd);
            if(table.Rows.Count > 0) { return true; } else
            {
                return false;
            }
        }

        public bool checkEmailAccountIsRegis(string email)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_CheckEmailUserIsRegis";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sEmail", email);
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool getPasswordAccountByEmail(string email)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GetPasswordAccountByEmail";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sEmail", email);
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0) 
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool changePasswordByUserID(int userID, string newPassword)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ChangePasswordByUserID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iUserID", userID);
            cmd.Parameters.AddWithValue("@sPassword", Functions.encrypt(newPassword));
            Functions.excuteNonQuery(cmd);
            return true;
        }

        public bool checkUserInfoByUserID(int userID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_CheckUserInfoByUserID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FK_iUserID", userID);
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool createAccount(int roleID, string userName, string email, DateTime createTime, string password)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_InsertUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FK_iRoleID", roleID);
            cmd.Parameters.AddWithValue("@sUserName", userName);
            cmd.Parameters.AddWithValue("@sEmail", email);
            cmd.Parameters.AddWithValue("@dCreateTime", createTime.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@sPassword", Functions.encrypt(password));
            Functions.excuteNonQuery(cmd);
            return true;
        }

        public bool createAccountInfo(int userID, string fullName, int gender, DateTime birth, DateTime updateTime, string image)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_InsertUserInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FK_iUserID", userID);
            cmd.Parameters.AddWithValue("@sFullName", fullName);
            cmd.Parameters.AddWithValue("@iGender", gender);
            cmd.Parameters.AddWithValue("@dDateBirth", birth.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@dUpdateTime", updateTime.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@sImageProfile", image);
            Functions.excuteNonQuery(cmd);
            return true;
        }

        public bool getAccountInfoByUserID(int userID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GetUserInfoByID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FK_iUserID", userID);
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateAccountInfo(int userID, string fullName, DateTime birth, DateTime updateTime, int gender, string image)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_UpdateProfile";
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FK_iUserID", userID);
            cmd.Parameters.AddWithValue("@sFullName", fullName);
            cmd.Parameters.AddWithValue("@dDateBirth", birth.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@dUpdateTime", updateTime.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@iGender", gender);
            cmd.Parameters.AddWithValue("@sImageProfile", image);
            Functions.excuteNonQuery(cmd);
            return true;
        }
    }
}
