using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineTicaret.Models.Siniflar
{
    public class KargoDetay
    {
        [Key]
        public int KargoDetayid { get; set; }
        [Column(TypeName = "Varchar(300)")]
        [StringLength(300)]
        public string Aciklama { get; set; }
        [Column(TypeName = "Varchar(10)")]
        [StringLength(10)]
        public string TakipKodu { get; set; }
        [Column(TypeName = "Varchar(20)")]
        [StringLength(20)]
        public string Personel { get; set; }
        [Column(TypeName = "Varchar(25)")]
        [StringLength(25)]
        public string Alici { get; set; }
        public DateTime Tarih { get; set; }
    }
}