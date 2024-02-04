using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrunTakipSistemi.Models.Entity;

namespace UrunTakipSistemi.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori

        DbMvcStokEntities db = new DbMvcStokEntities();
        public ActionResult Index()
        {
            var kategoriler = db.TblKategori.ToList();
            return View(kategoriler);
        }

        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniKategori(TblKategori p)
        {
            db.TblKategori.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriSil(int id)
        {
            var ktgr = db.TblKategori.Find(id);
            db.TblKategori.Remove(ktgr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int id)
        {
            var ktgr = db.TblKategori.Find(id);
            return View("KategoriGetir",ktgr);
        }

        public ActionResult KategoriGuncelle(TblKategori k)
        {
            var ktgr = db.TblKategori.Find(k.Id);
            ktgr.Ad=k.Ad;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}