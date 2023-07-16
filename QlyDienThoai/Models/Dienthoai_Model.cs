using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QlyDienThoai.Models;
using QlyDienThoai.DAL;

namespace QlyDienThoai.Models
{
    public class Dienthoai_Model
    {
        private List<CartItem> products;
        Dienthoai_DAL ob = new Dienthoai_DAL();
        public Dienthoai_Model() { }

        public List<CartItem> FillAll()
        {
            return this.products;
        }

        public CartItem FindDroduct(string Madt1)
        {
            var list = ob.Get_Dienthoai_byma(Madt1.Trim()).FirstOrDefault();
            this.products = new List<CartItem>()
            {
                new CartItem
                {
                    Madt = list.Madt,
                    Tendt = list.Tendt,
                    Giaban = list.Giaban,
                    Anhbia = list.Anhbia
                }
            };
            return this.products.FirstOrDefault();
        }
    }
}