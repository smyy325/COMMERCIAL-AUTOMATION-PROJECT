using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineTicaret.Models.Siniflar
{
    public class Personel
    {
        [Key]
        public int Personelid { get; set; }
        [Display(Name = "Personel Adı")]
        [Column(TypeName = "varchar(30)")] 
        [StringLength(30)]
        public string PersonelAd { get; set; }
        [Display(Name = "Personel Soyadı")]
        [Column(TypeName = "varchar(30)")] 
        [StringLength(30)]
        public string PersonelSoyad { get; set; }
        [Display(Name = "Personel Görsel")]
        [Column(TypeName = "varchar(250)")]
        [StringLength(250)]
        public string PersonelGorsel { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
        public int Departmanid {  get; set; }
        public virtual Departman Departman { get; set; }    
    }
}