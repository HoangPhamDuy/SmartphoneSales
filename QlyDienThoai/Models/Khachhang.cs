using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace QlyDienThoai.Models
{
    public class Khachhang
    {
        [Key]
        public string Makh { get; set; }
        [Required]
        public string Tenkh { get; set; }
        [Required]
        public string Diachi { get; set; }
        [Required]
        public string Sdt { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Madt { get; set; }
        [Required]
        public string Mansx { get; set; }
    }
}