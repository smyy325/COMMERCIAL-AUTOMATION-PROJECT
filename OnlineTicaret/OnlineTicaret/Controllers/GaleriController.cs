using OnlineTicaret.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineTicaret.Controllers
{
    public class GaleriController : Controller
    {
        // GET: Galeri
        ApplicationConnectionDb c = new ApplicationConnectionDb();
        public ActionResult Index()
        {
            var degerler = c.Uruns.ToList();
            return View(degerler);
        }
    }
}