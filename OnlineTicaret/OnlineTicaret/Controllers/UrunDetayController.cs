using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTicaret.Models.Siniflar;

namespace OnlineTicaret.Controllers
{
    public class UrunDetayController : Controller
    {
        ApplicationConnectionDb c = new ApplicationConnectionDb();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
           // var degerler=c.Uruns.Where(x=>x.Urunid==1).ToList();
           cs.Deger1=c.Uruns.Where(x=>x.Urunid==1).ToList();
           cs.Deger2=c.Detays.Where(y=>y.Detayid==1).ToList();
            return View(cs);
        }
    }
}