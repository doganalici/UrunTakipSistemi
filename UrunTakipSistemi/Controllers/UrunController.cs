using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrunTakipSistemi.Models.Entity;

namespace UrunTakipSistemi.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun

        DbMvcStokEntities db = new DbMvcStokEntities();
        public ActionResult Index()
        {
            var urunler = db.TblUrunler.ToList();
            return View(urunler);
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> ktg = (from x in db.TblKategori.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.Ad,
                                            Value = x.Id.ToString()
                                        }).ToList();
            ViewBag.drop = ktg;
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(TblUrunler p)
        {
            var ktgr = db.TblKategori.Where(x => x.Id == p.TblKategori.Id).FirstOrDefault();
            p.TblKategori = ktgr;
            db.TblUrunler.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UrunGetir(int id)
        {
            var urn = db.TblUrunler.Find(id);
            return View("UrunGetir", urn);
        }
    }
}