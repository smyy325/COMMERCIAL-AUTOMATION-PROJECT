using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicaret.Models.Siniflar
{
    public class SatisHareket
    {
        [Key]
        public int Satisid { get; set; }
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        [Column(TypeName = "varchar(5)")]
        [StringLength(5)]
        public decimal Fiyat { get; set; }
        [Column(TypeName = "varchar(5)")]
        [StringLength(5)]
        public decimal ToplamTutar { get; set; }
        public int Urunid { get; set; }
        public int Cariid { get; set; }
        public int Personelid { get; set; }
        public virtual Urun Urun { get; set; }
        public virtual Cari Cari { get; set; }
        public virtual Personel Personel { get; set; }
    }
}