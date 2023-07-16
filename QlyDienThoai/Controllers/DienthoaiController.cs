using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QlyDienThoai.Models;
using QlyDienThoai.DAL;

namespace QlyDienThoai.Controllers
{
    public class DienthoaiController : Controller
    {
        // GET: Dienthoai
        public ActionResult Index()
        {
            return View(new Dienthoai_DAL().Get_Dienthoai());
        }

        public ActionResult Details(string id)
        {
            return View(new Dienthoai_DAL().Get_Dienthoai_byma(id).FirstOrDefault());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Dienthoai d)
        {
            if (ModelState.IsValid)
            {
                new Dienthoai_DAL().Insert_Dienthoai(d);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(string id)
        {
            return View(new Dienthoai_DAL().Get_Dienthoai_byma(id).FirstOrDefault());
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult Delete_DT(string id)
        {
            if (ModelState.IsValid)
            {
                new Dienthoai_DAL().Delete_Dienthoai(id);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(string id)
        {
            return View(new Dienthoai_DAL().Get_Dienthoai_byma(id).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult Edit(Dienthoai ob)
        {
            if (ModelState.IsValid)
            {
                new Dienthoai_DAL().Update_Dienthoai(ob);
                return RedirectToAction("Index");
            }
            return View();
        }


    }
        
}