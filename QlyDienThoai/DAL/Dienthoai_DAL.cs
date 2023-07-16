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
    public class Dienthoai_DAL
    {
        string conString = ConfigurationManager.ConnectionStrings["adoConnectionString"].ToString();
        public List<Dienthoai> Get_Dienthoai()
        {
            List<Dienthoai> Dienthoai_List = new List<Dienthoai>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Sanpham";
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    Dienthoai_List.Add(new Dienthoai
                    {
                        Madt = dr[0].ToString(),
                        Tendt = dr[1].ToString(),
                        Giaban = float.Parse(dr[2].ToString()),
                        Mota = dr[3].ToString(),
                        Anhbia = dr[4].ToString(),
                        Noisx = dr[5].ToString(),
                        Namsx = DateTime.Parse(dr[6].ToString()),
                        Soluongton = int.Parse(dr[7].ToString()),
                        Mansx = dr[8].ToString(),

                    });
                }
                return Dienthoai_List;
            }
        }
        // Dùng để lọc các hãng điện thoại ( iphone , huawei, samsung ) trong cotroller
        public List<Dienthoai> Get_Dienthoai_bymansx(string Mansx)
        {
            List<Dienthoai> Dienthoai_List = new List<Dienthoai>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Sanpham where Mansx = '" + Mansx + "'";
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    Dienthoai_List.Add(new Dienthoai
                    {
                        Madt = dr[0].ToString(),
                        Tendt = dr[1].ToString(),
                        Giaban = float.Parse(dr[2].ToString()),
                        Mota = dr[3].ToString(),
                        Anhbia = dr[4].ToString(),
                        Noisx = dr[5].ToString(),
                        Namsx = DateTime.Parse(dr[6].ToString()),
                        Soluongton = int.Parse(dr[7].ToString()),
                        Mansx = dr[8].ToString(),

                    });
                }
                return Dienthoai_List;
            }
        }
        public List<Dienthoai> Get_Dienthoai_byma(string Madt)
        {
            List<Dienthoai> Dienthoai_List = new List<Dienthoai>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Sanpham where Madt = '" + Madt + "'";
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    Dienthoai_List.Add(new Dienthoai
                    {
                        Madt = dr[0].ToString(),
                        Tendt = dr[1].ToString(),
                        Giaban = float.Parse(dr[2].ToString()),
                        Mota = dr[3].ToString(),
                        Anhbia = dr[4].ToString(),
                        Noisx = dr[5].ToString(),
                        Namsx = DateTime.Parse(dr[6].ToString()),
                        Soluongton = int.Parse(dr[7].ToString()),
                        Mansx = dr[8].ToString(),

                    });
                }
                return Dienthoai_List;
            }
        }

        public void Insert_Dienthoai(Dienthoai ob)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string sql = "Insert into Sanpham values('" + ob.Madt + "', '" + ob.Tendt + "', '" + ob.Giaban + "', '" + ob.Mota + "', '" + ob.Anhbia + "', '" + ob.Noisx + "', '" + ob.Namsx + "', '" + ob.Soluongton + "', '" + ob.Mansx + "')";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete_Dienthoai(string ma)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string sql = "Delete from Sanpham where Madt = '" + ma + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update_Dienthoai(Dienthoai ob)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string sql = "Update Sanpham set Tendt = '" + ob.Tendt + "' where Madt = '" + ob.Madt + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}