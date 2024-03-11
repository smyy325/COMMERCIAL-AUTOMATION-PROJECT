using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicaret.Models.Siniflar
{
    public class Cari
    {
        [Key]
        public int Cariid { get; set; }

        [StringLength(30)]
        public string CariAd { get; set; }

        [StringLength(30)]

        public string CariSoyad { get; set; }

        [StringLength(13)]
        public string CariSehir { get; set; }

        [StringLength(50)]
        public string CariMail { get; set; }


        [StringLength(20)]
        public string CariSifre { get; set; }
        public bool Durum { get; set; }

        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}