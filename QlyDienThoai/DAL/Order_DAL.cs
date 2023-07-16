using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using QlyDienThoai.Models;

namespace QlyDienThoai.DAL
{
    public class Order_DAL
    {
        string conString = ConfigurationManager.ConnectionStrings["adoConnectionString"].ToString();
        public void Insert_Order(Order ob)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string sql = "Insert into [dbo].[Order] (Name,Userid,Status,CreateOrder)" + "values('" + ob.Name + "', " + ob.Userid + ", " + ob.Status + ", '" + ob.CreateOrder.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

    }
}