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

        public ActionResult ChuDe(int id) // id is the MaCD
        {
            QLBANSACHEntities1 db = new QLBANSACHEntities1();
            var chuDeList = db.CHUDEs.ToList(); // Lấy danh sách chủ đề từ cơ sở dữ liệu
            var NXBList = db.NHAXUATBANs.ToList();
            ViewBag.ChuDeList = chuDeList;
            ViewBag.NXBList = NXBList;
            var books = db.SACHes.Where(b => b.MaCD == id).ToList(); // Fetch books for the given category
            return View(books);
        }
        
        public ActionResult nxb(int id)
        {
            QLBANSACHEntities1 db = new QLBANSACHEntities1();
            var chuDeList = db.CHUDEs.ToList(); // Lấy danh sách chủ đề từ cơ sở dữ liệu
            var NXBList = db.NHAXUATBANs.ToList();
            ViewBag.ChuDeList = chuDeList;
            ViewBag.NXBList = NXBList;
            var books = db.SACHes.Where(b => b.MaNXB == id).ToList(); // Fetch books for the given category
            return View(books);
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

    }
}