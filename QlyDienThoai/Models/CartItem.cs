using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QlyDienThoai.Models
{
    public class CartItem
    {
        public String Madt { get; set; }
        [DisplayName("Tên")]
        public String Tendt { get; set; }
        [DisplayName("Đơn giá")]
        public float Giaban { get; set; }
        [DisplayName("Ảnh bìa")]
        public String Anhbia { get; set; }
        [DisplayName("Số lượng")]
        public int Soluong { get; set; }
        [DisplayName("Thành tiền")]
        public float Thanhtien
        {
            get
            {
                return Giaban * Soluong;
            }
        }
    }
}