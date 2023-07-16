using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using QlyDienThoai.Models;

namespace QlyDienThoai.DAL
{
    public class Order_detail_DAL
    {
        string conString = ConfigurationManager.ConnectionStrings["adoConnectionString"].ToString();
        public void Insert_Order_Detail(Order_detail ob1)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string sql = "Insert into Order_detail (Orderid,Madt,Soluong,Dongia)" + "values('" + ob1.Orderid + "', '" + ob1.Madt + "', '" + ob1.Soluong + "', '" + ob1.Dongia + "')";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}