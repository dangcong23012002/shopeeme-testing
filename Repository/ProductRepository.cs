using ShopeeMe.Tests.Func;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeMe.UnitTests.Repository
{
    public class ProductRepository
    {
        public bool getProducts()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectProducts";
            cmd.CommandType = CommandType.StoredProcedure;
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

        public bool getProductsByCategoryID(int categoryID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectProductsByCategoryID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FK_iCategoryID", categoryID);
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

        public bool getProductsByParentCategoryID(int parentCategoryID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectProductsByParentCategoryID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FK_iParentCategoryID", parentCategoryID);
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

        public bool getProductsByCategoryIDIfRoleAdmin(int categoryID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectProductsByCategoryIDIfRoleAdmin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FK_iCategoryID", categoryID);
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
    }
}
