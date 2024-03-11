using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicaret.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int Adminid { get; set; }

        [Column(TypeName = "varchar(10)")] 
        [StringLength(10)]
        public string KullaniciAd { get; set; }

        [Column(TypeName = "varchar(30)")] 
        [StringLength(30)]
        public string Sifre { get; set; }

        [Column(TypeName = "char(1)")] 
        [StringLength(1)]
        public string Yetki { get; set; }

    }
}