using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineTicaret.Models.Siniflar
{
    public class Fatura
    {
        [Key]
        public int FaturaID { get; set; }

        [Column(TypeName = "char(1)")] 
        [StringLength(1)]
        public string FaturaSeriNo { get; set; }

        [Column(TypeName = "char(1)")]
        [StringLength(1)]
        public string FaturaSiraNo { get; set; }

        public DateTime Tarih { get; set; }

        [Column(TypeName = "varchar(60)")] 
        [StringLength(60)]
        public string VergiDairesi { get; set; }

        [Column(TypeName = "char(5)")]
        [StringLength(5)]
        public string Saat { get; set; }

        [Column(TypeName = "varchar(30)")] 
        [StringLength(30)]
        public string TeslimEden { get; set; }

        [Column(TypeName = "varchar(30)")] 
        [StringLength(30)]
        public string TeslimAlan { get; set; }
        public decimal Toplam { get; set; }
        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}