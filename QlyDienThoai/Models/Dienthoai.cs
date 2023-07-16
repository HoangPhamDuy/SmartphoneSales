using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace QlyDienThoai.Models
{
    public class Dienthoai
    {
        [Key]
        public string Madt { get; set; }
        [Required]
        public string Tendt { get; set; }
        [Required]
        public float Giaban { get; set; }
        [Required]
        public string Mota { get; set; }
        [Required]
        public string Anhbia { get; set; }
        [Required]
        public string Noisx { get; set; }
        [Required]
        public DateTime Namsx { get; set; }
        [Required]
        public int Soluongton { get; set; }
        [Required]
        public string Mansx { get; set; }
    }
}