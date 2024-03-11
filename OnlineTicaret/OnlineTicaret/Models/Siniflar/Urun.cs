using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineTicaret.Models.Siniflar
{
    public class Urun
    {
        [Key]
        public int Urunid { get; set; }

        [Column(TypeName = "varchar(30)")] // varchar(30) olarak düzeltilmiş
        [StringLength(30)]
        public string UrunAd { get; set; }

        [Column(TypeName = "varchar(30)")] // varchar(30) olarak düzeltilmiş
        [StringLength(30)]
        public string Marka { get; set; }
        public short Stok { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public bool Durum { get; set; }

        [Column(TypeName = "Varchar(250)")]
        [StringLength(250)]
        public string UrunGorsel { get; set; }
        public int Kategoriid { get; set; }
        public string KategoriAd { get; set; }

        public virtual Kategori Kategori { get; set; }

        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}