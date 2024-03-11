using OnlineTicaret.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OnlineTicaret.Controllers
{
    public class FaturaController : Controller
    {
        // GET: Fatura
        ApplicationConnectionDb c = new ApplicationConnectionDb();
        public ActionResult Index()
        {
            var liste = c.Faturas.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult FaturaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FaturaEkle(Fatura f)
        {
            c.Faturas.Add(f);           
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FaturaGetir(int id)
        {
            var fatura = c.Faturas.Find(id);
            return View("FaturaGetir",fatura);
        }
        public ActionResult FaturaGuncelle(Fatura f)
        {
            var fatura = c.Faturas.Find(f.FaturaID);
            fatura.FaturaSeriNo = f.FaturaSeriNo;
            fatura.FaturaSiraNo = f.FaturaSiraNo;
            fatura.Saat=f.Saat;
            fatura.Tarih=f.Tarih;
            fatura.TeslimAlan=f.TeslimAlan;
            fatura.TeslimEden=f.TeslimEden;
            fatura.VergiDairesi=f.VergiDairesi;
            c.SaveChanges() ;
            
            return RedirectToAction("Index");
        }
        public ActionResult FaturaDetay(int id)
        {
            var degerler = c.FaturaKalems.Where(x => x.Faturaid == id).ToList();
            
           
            return View(degerler);

        }
        [HttpGet]
        public ActionResult YeniKalem()
        {
            return View();
        }
        public ActionResult YeniKalem(FaturaKalem p)
        {
            c.FaturaKalems.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}