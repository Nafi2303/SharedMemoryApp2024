using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MvcFoad2024_2.Models;

namespace MvcFoad2024_2
{
    [Table("td_auteur")]
    public class Auteur:Utilisateur
    {
        [Display(Name = "Anciennete")]
        public int Anciennete { get; set; }

        [Required]
        public ICollection<Memoire> memoires { get; set;}
    }
}