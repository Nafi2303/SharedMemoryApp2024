using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MvcFoad2024_2.Models;

namespace MvcFoad2024_2
{
    [Table("td_expert")]
    public class Expert:Utilisateur
    {
        [Display(Name = "Specialite")]
        public string specialite { get; set; }

        public virtual ICollection<Commentaire> commentaires { get; set; }
    }
}