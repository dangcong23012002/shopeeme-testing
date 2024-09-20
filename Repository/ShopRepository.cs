﻿using ShopeeMe.Tests.Func;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeMe.UnitTests.Repository
{
    public class ShopRepository
    {
        public bool getShops()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GetStores";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0 )
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool getShopByID(int shopID) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GetShopByID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iShopID", shopID);
            DataTable table = Functions.getData(cmd);
            if (table.Rows.Count > 0 )
            {
                return true;
            } else
            {
                return true;
            }
        }
    }
}