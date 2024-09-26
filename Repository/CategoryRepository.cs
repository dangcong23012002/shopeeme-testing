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
    }
}
