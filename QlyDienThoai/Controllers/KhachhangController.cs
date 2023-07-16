using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QlyDienThoai.Models;
using QlyDienThoai.DAL;


namespace QlyDienThoai.Controllers
{
    public class KhachhangController : Controller
    {
        // GET: Khachhang
        public ActionResult Index()
        {
            return View(new Khachhang_DAL().Get_Khachhang());
        }
        public ActionResult Details(string id)
        {
            return View(new Khachhang_DAL().Get_Khachhang_Byma(id).FirstOrDefault());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Khachhang k)
        {
            if (ModelState.IsValid)
            {
                new Khachhang_DAL().Insert_Khachhang(k);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(string id)
        {
            return View(new Khachhang_DAL().Get_Khachhang_Byma(id).FirstOrDefault());
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult Delete_kh(string id)
        {
            if (ModelState.IsValid)
            {
                new Khachhang_DAL().Delete_Khachhang(id);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(string id)
        {
            return View(new Khachhang_DAL().Get_Khachhang_Byma(id).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult Edit(Khachhang ob)
        {
            if (ModelState.IsValid)
            {
                new Khachhang_DAL().Update_Khachhang(ob);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}