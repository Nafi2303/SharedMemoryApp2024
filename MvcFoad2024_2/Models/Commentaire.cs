using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFoad2024_2.Models
{
    [Table("td_commentaire")]
    public class Commentaire
    {
        [Key]
        public int Id { get; set; }

        public string contenu { get; set;}

        public Memoire memoires { get; set;}

        public Lecteur lecteurs { get; set;}

        public Expert experts { get; set;}
    }
}