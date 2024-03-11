using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicaret.Models.Siniflar
{
    public class Detay
    {
        [Key]
        public int Detayid { get; set; }
        [Column(TypeName = "varchar(30)")]
        [StringLength(30)]
        public string UrunAd { get; set; }
        [Column(TypeName = "varchar(2000)")]
        [StringLength(2000)]
        public string UrunBilgi { get; set; }
    }
}