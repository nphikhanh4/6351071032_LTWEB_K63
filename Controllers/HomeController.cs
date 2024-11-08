using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        QLBANSACHEntities1 db = new QLBANSACHEntities1();

        public ActionResult Index()
        {
            using (QLBANSACHEntities1 db = new QLBANSACHEntities1())
            {
                List<SACH> dsSach = db.SACHes.ToList();
                var chuDeList = db.CHUDEs.ToList(); // Lấy danh sách chủ đề từ cơ sở dữ liệu
                var NXBList = db.NHAXUATBANs.ToList();
                ViewBag.ChuDeList = chuDeList;
                ViewBag.NXBList = NXBList;
                return View(dsSach);
            }
        }


        public ActionResult ChuDe()
        {
            var cate = db.CHUDEs.ToList();
            return PartialView(cate);
        }

        public ActionResult itemChuDe(int id)
        {
            var book = db.SACHes.Where(s => s.MaCD == id).ToList();
            return View(book);
        }

        public ActionResult NXB()
        {
            var cate = db.NHAXUATBANs.ToList();
            return PartialView(cate);
        }
        public ActionResult itemNXB(int id)
        {
            var book = db.SACHes.Where(s => s.MaNXB == id).ToList();
            return View(book);
        }
        
        public ActionResult ChiTiet(int id)
        {
            using (QLBANSACHEntities1 db = new QLBANSACHEntities1())
            {
                var chuDeList = db.CHUDEs.ToList(); // Lấy danh sách chủ đề từ cơ sở dữ liệu
                var NXBList = db.NHAXUATBANs.ToList();
                ViewBag.ChuDeList = chuDeList;
                ViewBag.NXBList = NXBList;
                var books = db.SACHes.Where(b => b.Masach == id).ToList();
                return View(books);
            }
        }
    public ActionResult layoutLeft()
        {
            using (QLBANSACHEntities1 db = new QLBANSACHEntities1())
            {
                List<SACH> dsSach = db.SACHes.ToList();
                var chuDeList = db.CHUDEs.ToList(); // Lấy danh sách chủ đề từ cơ sở dữ liệu
                var NXBList = db.NHAXUATBANs.ToList();
                ViewBag.ChuDeList = chuDeList;
                ViewBag.NXBList = NXBList;
                return View(dsSach);
            }
        }
    }
}