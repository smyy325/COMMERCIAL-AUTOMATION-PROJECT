using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineTicaret.Models.Siniflar
{
    public class Yapilacak
    {
        [Key]
        public int Yapilacakid { get; set; }

        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        public string Baslik { get; set; }

        [Column(TypeName = "bit")]

        public bool Durum { get; set; }


    }
}