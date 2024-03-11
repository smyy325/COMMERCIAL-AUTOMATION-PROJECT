using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using OnlineTicaret.Models.Siniflar;

namespace OnlineTicaret.Controllers
{
    public class CariController : Controller
    {
        // GET: Cari
        ApplicationConnectionDb c = new ApplicationConnectionDb();
        public ActionResult Index()
        {
            var degerler = c.Caris.Where(x => x.Durum == true).ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniCari()
        {
            return View();
        }
        public ActionResult YeniCari(Cari p)
        {
            p.Durum = true;
            c.Caris.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CariSil(int id)
        {
            var cr = c.Caris.Find(id);
            cr.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CariGetir(int id)
        {
            var cari = c.Caris.Find(id);
            return View("CariGetir", cari);
        }
        public ActionResult CariGuncelle(Cari p)
        {
            var cari = c.Caris.Find(p.Cariid);
            cari.CariAd = p.CariAd;
            cari.CariSoyad = p.CariSoyad;
            cari.CariSehir = p.CariSehir;
            cari.CariMail = p.CariMail;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriSatis(int id)
        {
            var degerler = c.SatisHarekets.Where(x => x.Cariid == id).ToList();
            var cr = c.Caris.Where(x => x.Cariid == id).Select(y => y.CariAd + " " + y.CariSoyad).FirstOrDefault();
            ViewBag.cari = cr;
            return View(degerler);
        }
    }

}