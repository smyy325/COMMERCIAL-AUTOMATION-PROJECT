using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTicaret.Models.Siniflar;
namespace OnlineTicaret.Controllers
{
    [Authorize]
    public class DepartmanController : Controller
    {
        // GET: Departman
        ApplicationConnectionDb c = new ApplicationConnectionDb();
        public ActionResult Index()
        {
            var degerler = c.Departmans.Where(x => x.Durum == true).ToList();
            return View(degerler);
        }
        [Authorize(Roles = "A")]

        [HttpGet]
        public ActionResult DepartmanEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DepartmanEkle(Departman d)
        {
            d.Durum = true;
            c.Departmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanSil(int id)
        {
            var dep = c.Departmans.Find(id);
            dep.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanGetir(int id)
        {
            var dpt = c.Departmans.Find(id);
            return View("DepartmanGetir", dpt);
        }
        public ActionResult DepartmanGuncelle(Departman p)
        {
            var dpt = c.Departmans.Find(p.Departmanid);
            dpt.DepartmanAd = p.DepartmanAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanDetay(int id)
        {
            var degerler = c.Personels.Where(x => x.Departmanid == id).ToList();
            var dpt=c.Departmans.Where(x=>x.Departmanid ==id).ToList().Select(y=>y.DepartmanAd).FirstOrDefault();
            ViewBag.d = dpt;
            return View(degerler);
        }
        public ActionResult DepatmanPersonelSatış(int id)
        {
            var degerler = c.SatisHarekets.Where(x => x.Personelid == id).ToList();
            var per=c.Personels.Where(x=>x.Personelid==id).Select(y=>y.PersonelAd+" "+y.PersonelSoyad).FirstOrDefault();
            ViewBag.dpers = per;
            return View(degerler);
        }
    }
}