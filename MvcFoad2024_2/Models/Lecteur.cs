using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcFoad2024_2.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFoad2024_2
{
    [Table("td_lecteur")]
    public class Lecteur:Utilisateur
    {
        [Display (Name = "Specialite")]
        public string specialite { get; set; }

        public virtual ICollection<Commentaire> commentaires { get; set; }

        public virtual ICollection<Memoire> memoires{ get; set; }
    }
}