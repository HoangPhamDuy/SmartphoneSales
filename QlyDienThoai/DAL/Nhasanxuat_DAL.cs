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
    public class Nhasanxuat_DAL
    {
        string conString = ConfigurationManager.ConnectionStrings["adoConnectionString"].ToString();
        public List<Nhasanxuat> Get_Nhasanxuat()
        {
            List<Nhasanxuat> Nhasanxuat_List = new List<Nhasanxuat>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Nhasanxuat";
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    Nhasanxuat_List.Add(new Nhasanxuat
                    {
                        Mansx = dr[0].ToString(),
                        Tennsx = dr[1].ToString(),

                    });
                }
                return Nhasanxuat_List;
            }
        }

        public List<Nhasanxuat> Get_Nhasanxuat_byma(string Mansx)
        {
            List<Nhasanxuat> Nhasanxuat_List = new List<Nhasanxuat>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Nhasanxuat where Mansx = '" + Mansx + "'";
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    Nhasanxuat_List.Add(new Nhasanxuat
                    {
                        Mansx = dr[0].ToString(),
                        Tennsx = dr[1].ToString(),
                       
                    });
                }
                return Nhasanxuat_List;
            }
        }
    }
}