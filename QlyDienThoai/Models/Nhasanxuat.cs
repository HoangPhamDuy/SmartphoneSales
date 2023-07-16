using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace QlyDienThoai.Models
{
    public class Nhasanxuat
    {
        [Key]
        public string Mansx { get; set; }
        [Required]
        public string Tennsx { get; set; }
    }
}