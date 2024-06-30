using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFoad2024_2.Models
{
    [Table("td_document")]
    public class Document
    {
        [Key]
        public int idDocument { get; set; }
        [Display(Name = "Nom"), Required(ErrorMessage ="*"), MaxLength(200, ErrorMessage ="La taille maximale est de 200")]
        public string Nom { get; set; }
        [Display(Name = "Extension"), Required(ErrorMessage = "*"), MaxLength(10, ErrorMessage = "La taille maximale est de 200")]
        public string Extension { get; set; }

        public int? IdMemoire { get; set; }
        [ForeignKey("IdMemoire")]
        public Memoire Memoire { get; set; }
    }
}