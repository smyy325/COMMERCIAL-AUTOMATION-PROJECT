﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTicaret.Models.Siniflar;

namespace OnlineTicaret.Controllers
{
    public class YapilacakController : Controller
    {
        // GET: Default
        ApplicationConnectionDb c = new ApplicationConnectionDb();
        public ActionResult Index()
        {
            var deger1 = c.Caris.Count().ToString();
            ViewBag.d1 = deger1;
            var deger2 = c.Uruns.Count().ToString();
            ViewBag.d2 = deger2;
            var deger3 = c.Kategoris.Count().ToString();
            ViewBag.d3 = deger3;
            var deger4 = (from x in c.Caris select x.CariSehir).Distinct().ToList();
            ViewBag.d4 = deger4;



            var yapilacaklar = c.Yapilacaks.ToList();
            return View(yapilacaklar);
        }
    }
}