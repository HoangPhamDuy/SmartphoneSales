using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QlyDienThoai.Models
{
    public class Order_detail
    {
        public int Id { get; set; }
        public int Orderid { get; set; }

        public string Madt { get; set; }
        public int Soluong { get; set; }
        public float Dongia { get; set; }
    }
}