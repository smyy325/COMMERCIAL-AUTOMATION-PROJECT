using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineTicaret.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        public int Kategoriid { get; set; }

        [Column(TypeName = "varchar(30)")]
        [StringLength(30)]
        public string KategoriAd { get; set; }

        public ICollection<Urun> Uruns { get; set; }
    }
}