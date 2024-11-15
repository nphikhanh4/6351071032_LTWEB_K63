using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PagedList;
using PagedList.Mvc;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        QLBANSACHEntities1 db = new QLBANSACHEntities1();

        public ActionResult Index(int? page)
        {
            int pageSize = 5;
            int pageNum = (page ?? 1);

            var sachMoi = laysachmoi(15);

            return View(sachMoi.ToPagedList(pageNum, pageSize));    
        }

        private List<SACH> laysachmoi(int count)
        {
            QLBANSACHEntities1 data = new QLBANSACHEntities1();
            return data.SACHes.OrderByDescending(a => a.Ngaycapnhat).ToList();
        }

        public ActionResult GetNewestBook(int a = 5)
        {
            ViewBag.a = a;
            var books = db.SACHes
              .Include("CHUDE")
              .Include("NHAXUATBAN")
              .OrderByDescending(b => b.Ngaycapnhat) 
              .Take(a)
              .ToList();
            return View(books);
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
                var books = db.SACHes.Where(b => b.Masach == id).ToList();
                return View(books);
            }
        }
    }
}