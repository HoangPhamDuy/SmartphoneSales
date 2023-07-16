using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QlyDienThoai.DAL;
using QlyDienThoai.Models;


namespace QlyDienThoai.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string Nhasanxuat = "")
        {
            Dienthoai_DAL ob = new Dienthoai_DAL();
            
            //var Dienthoai_List = ob.Get_Dienthoai();
            //return View(Dienthoai_List);
            if (Nhasanxuat != "")
            {

                return View(ob.Get_Dienthoai_bymansx(Nhasanxuat));
            }
            else
            {
                return View(ob.Get_Dienthoai());
            }
        }
    }
}