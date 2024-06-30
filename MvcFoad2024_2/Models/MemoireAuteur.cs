using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFoad2024_2.Models
{
    public class MemoireAuteur
    {
        [Key, Column(Order =1)]
      public int? IdAuteur { get; set; }
        [ForeignKey("IdAuteur")]
      public virtual Auteur Auteur { get; set; }
        [Key, Column(Order =2)]
      public int? IdMemoire { get; set;}
        [ForeignKey("IdMemoire")]
      public virtual Memoire Memoire { get; set; }
    }
}