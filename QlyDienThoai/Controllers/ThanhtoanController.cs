using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QlyDienThoai.Models;
using QlyDienThoai.DAL;

namespace QlyDienThoai.Controllers
{
    public class ThanhtoanController : Controller
    {
        // GET: Thanhtoan
        Order_DAL order = new Order_DAL();
        Order_detail_DAL order_Detail = new Order_detail_DAL();
        public ActionResult Index()
        {
            var Listcart = (List<CartItem>)Session["ShopingCart"];
            Order ob = new Order();
            ob.Name = "Don Hang" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            ob.Userid = 1;
            ob.Status = 0;
            ob.CreateOrder = DateTime.Now;
            order.Insert_Order(ob);
            int orderid = ob.Id;
            foreach (var item in Listcart)
            {
                Order_detail ob1 = new Order_detail();
                ob1.Orderid = orderid;
                ob1.Madt = item.Madt;
                ob1.Soluong = item.Soluong;
                ob1.Dongia = item.Giaban;
                order_Detail.Insert_Order_Detail(ob1);
            }
            return View();
        }
    }
}