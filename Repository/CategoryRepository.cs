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
    public class CategoryRepository
    {
        public bool getParentCategories()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectParentCategories";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool getCategories()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectCategories";
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool getCategoriesByParentCategoryID(int parentCategoryID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectCategoriesByParentCategoryID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FK_iParentCategoryID", parentCategoryID);
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool getCategoriesByShopID(int shopID) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GetAllCategoriesByShopID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FK_iShopID", shopID);
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool insertCategory(int storeID = 0, int parentCategoryID = 0, string categoryName = "", string categoryImage = "", string categoryDesc = "")
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_InsertCategory";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FK_iStoreID", storeID);
            cmd.Parameters.AddWithValue("@FK_iParentCategoryID", parentCategoryID);
            cmd.Parameters.AddWithValue("@sCategoryName", categoryName);
            cmd.Parameters.AddWithValue("@sCategoryImage", categoryImage);
            cmd.Parameters.AddWithValue("@sCategoryDescription", categoryDesc);
            cmd.Parameters.AddWithValue("@iIsVisible", 1);
            Functions.excuteNonQuery(cmd);
            return true;
        }
    }
}
