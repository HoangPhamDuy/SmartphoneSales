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
    public class Khachhang_DAL
    {
        string conString = ConfigurationManager.ConnectionStrings["adoConnectionString"].ToString();
        public List<Khachhang> Get_Khachhang()
        {
            List<Khachhang> Khachhang_List = new List<Khachhang>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Khachhang";
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    Khachhang_List.Add(new Khachhang
                    {
                        Makh = dr[0].ToString(),
                        Tenkh = dr[1].ToString(),
                        Diachi = dr[2].ToString(),
                        Sdt = dr[3].ToString(),
                        Email = dr[4].ToString(),
                        Madt = dr[5].ToString(),
                        Mansx = dr[6].ToString(),

                    });
                }
                return Khachhang_List;
            }
        }

        public List<Khachhang> Get_Khachhang_Byma(string Makh)
        {
            List<Khachhang> Khachhang_List = new List<Khachhang>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Khachhang where Makh = '" + Makh + "'";
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    Khachhang_List.Add(new Khachhang
                    {
                        Makh = dr[0].ToString(),
                        Tenkh = dr[1].ToString(),
                        Diachi = dr[2].ToString(),
                        Sdt = dr[3].ToString(),
                        Email = dr[4].ToString(),
                        Madt = dr[5].ToString(),
                        Mansx = dr[6].ToString(),

                    });
                }
                return Khachhang_List;
            }
        }
        public void Insert_Khachhang(Khachhang ob)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string sql = "Insert into Khachhang values('" + ob.Makh + "', '" + ob.Tenkh + "', '" + ob.Sdt + "', '" + ob.Diachi + "', '" + ob.Email + "', '" + ob.Madt + "', '" + ob.Mansx + "')";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete_Khachhang(string ma)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string sql = "Delete from Khachhang where Makh = '" + ma + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update_Khachhang(Khachhang ob)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string sql = "Update Khachhang set Tenkh = '" + ob.Tenkh + "' where Makh = '" + ob.Makh + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}