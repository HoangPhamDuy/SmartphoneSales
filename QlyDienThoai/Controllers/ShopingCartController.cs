using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QlyDienThoai.Models;
using QlyDienThoai.DAL;

namespace QlyDienThoai.Controllers
{
    public class ShopingCartController : Controller
    {
        // GET: ShopingCart
        public ActionResult Index()
        {
            List<CartItem> ShopingCart = Session["ShopingCart"] as List<CartItem>;
            return View(ShopingCart);
        }
        public RedirectToRouteResult AddToCart(string Madt1)
        {
            if (Session["ShopingCart"] == null)
            {
                Session["ShopingCart"] = new List<CartItem>();
            }
            List<CartItem> ShopingCart = Session["ShopingCart"] as List<CartItem>;

            if (ShopingCart.FirstOrDefault(m => m.Madt == Madt1) == null)
            {
                Dienthoai_Model db = new Dienthoai_Model();
                CartItem prodouct = db.FindDroduct(Madt1);
                CartItem newItem = new CartItem()
                {
                    Madt = prodouct.Madt,
                    Tendt = prodouct.Tendt,
                    Soluong = 1,
                    Anhbia = prodouct.Anhbia,
                    Giaban = prodouct.Giaban
                };
                ShopingCart.Add(newItem);
            }
            else
            {
                CartItem cardItem = ShopingCart.FirstOrDefault(m => m.Madt == Madt1);
                cardItem.Soluong++;
            }
            return RedirectToAction("Index", "ShopingCart");
        }

        public ActionResult CapnhatGiohang(string Madt1, FormCollection f)
        {
            List<CartItem> ShoppingCart = Session["ShopingCart"] as List<CartItem>;
            CartItem EditAmount = ShoppingCart.FirstOrDefault(m => m.Madt == Madt1);
            if (EditAmount != null)
            {
                EditAmount.Soluong = int.Parse(f["txtsoluong"].ToString());
            }
            return RedirectToAction("Index");
        }

        public ActionResult RemoveItem(string Madt1)
        {
            List<CartItem> ShoppingCart = Session["ShopingCart"] as List<CartItem>;
            CartItem DelItem = ShoppingCart.FirstOrDefault(m => m.Madt == Madt1);
            if (DelItem != null)
            {
                ShoppingCart.Remove(DelItem);
            }
            return RedirectToAction("Index");
        }
    }
}