using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace OnlineTicaret.Models.Siniflar
{
    public class mesajlar
    {

        [Key]
        public int MesajID { get; set; }

        [Column(TypeName = "Varchar(50)")]
        [StringLength(50)]
        public string Gonderici { get; set; }

        [Column(TypeName = "Varchar(50)")]
        [StringLength(50)]
        public string Alici { get; set; }

        [Column(TypeName = "Varchar(50)")]
        [StringLength(50)]
        public string Konu { get; set; }

        [Column(TypeName = "Varchar(2000)")]
        [StringLength(2000)]
        public string icerik { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Tarih { get; set; }


    }
}