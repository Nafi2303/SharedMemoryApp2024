using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MvcFoad2024_2.Models
{
    [Table("td_auteur")]
    public class Auteur:Utilisateur
    {
        [Display(Name ="Ancienneté", ResourceType =typeof(ResourceFr))]
        public int Anciennete { get; set; }
       //[Required]
      //public ICollection<Memoire> memoires { get; set;}
    }
}