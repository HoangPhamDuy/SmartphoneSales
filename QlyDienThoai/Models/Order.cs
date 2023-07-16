using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QlyDienThoai.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Userid { get; set; }
        public int Status { get; set; }
        public DateTime CreateOrder { get; set; }
    }
}