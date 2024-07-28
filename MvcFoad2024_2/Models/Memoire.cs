 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFoad2024_2.Models
{
    [Table("td_memoire")]
    public class Memoire
    {
        [Key]
        public int IdMemoire { get; set; }

        [Display(Name ="Titre memoire"), Required(ErrorMessage ="*"), MaxLength(200, ErrorMessage ="La taille maximale est de 200 caracteres")]
        public string Nom { get; set; }
        [Display(Name = "Niveau"), Required(ErrorMessage = "*"), MaxLength(20, ErrorMessage = "La taille maximale est de 20 caracteres")]
        public string Niveau { get; set; }
        [Display(Name = "Auteur ou redacteur"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "La taille maximale est de 100 caracteres")]
        public string Auteur { get; set; }
        [Display(Name = "Annee de memoire"), Required(ErrorMessage = "*"), MaxLength(10, ErrorMessage = "La taille maximale est de 10 caracteres")]
        public string Annee { get; set; }
        [Display(Name = "Specialite"), Required(ErrorMessage = "*"), MaxLength(150, ErrorMessage = "La taille maximale est de 150 caracteres")]
        public string Specialite { get; set; }
        [Display(Name = "Description"), Required(ErrorMessage = "*"), MaxLength(2000, ErrorMessage = "La taille maximale est de 2000 caracteres")]
        public string Description { get; set; }
        [Display(Name = "Etat"), Required(ErrorMessage = "*"), MaxLength(20, ErrorMessage = "La taille maximale est de 20 caracteres")]
        public string Etat { get; set; }
        [Display(Name = "Note Finale"), Required(ErrorMessage = "*")]
        public float NoteFinale { get; set; }
        [Display(Name = "Appreciation"), Required(ErrorMessage = "*"), MaxLength(200, ErrorMessage = "La taille maximale est de 20 caracteres")]
        public string Appreciation { get; set; }
        [Display(Name = "Verdict"), Required(ErrorMessage = "*"), MaxLength(200, ErrorMessage = "La taille maximale est de 20 caracteres")]
        public string Verdict { get; set; }

        public virtual ICollection<Commentaire> commentaires { get; set; }
        public Bibliothecaire Bibliothecaire { get; set; }

        //public Document Document { get; set; }

        [Required]
      //  public virtual ICollection<Auteur> auteurs { get; set;}

        public virtual ICollection<Lecteur> lecteurs { get; set; }
    }


}