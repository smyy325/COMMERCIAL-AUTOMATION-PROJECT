using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineTicaret.Models.Siniflar
{
    public class KargoTakip
    {
        [Key]
        public int KargoTakipid { get; set; }
        [Column(TypeName = "Varchar(10)")]
        [StringLength(10)]
        public string TakipKodu { get; set; }
        [Column(TypeName = "Varchar(100)")]
        [StringLength(100)]
        public string Aciklama { get; set; }
        public DateTime TarihZaman { get; set; }
    }
}