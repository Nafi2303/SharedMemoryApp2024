using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFoad2024_2.Models
{
    public class Profil
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string CodeProfil { get; set; }
        [Required, MaxLength(150)]
        public string LibelleProfil { get; set; }

    }
}