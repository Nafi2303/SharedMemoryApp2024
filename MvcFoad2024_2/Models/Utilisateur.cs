using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcFoad2024_2.Models
{
    [Table("td_utilisateur")]
    public class Utilisateur
    {
        [Key]
        public int IdUtilisateur { get; set; }
        [Display(Name = "Nom"), Required(ErrorMessage = "*"), MaxLength(80, ErrorMessage = "La taille maximale est de 80 caracteres")]
        public string NomUtilisateur { get; set; }
        [Display(Name = "Prénom"), Required(ErrorMessage = "*"), MaxLength(80, ErrorMessage = "La taille maximale est de 80 caracteres")]
        public string PrenomUtilisateur { get; set; }
        [Display(Name = "Numéro"), MaxLength(15, ErrorMessage = "La taille maximale est de 15 caracteres")]
        public string TelUtilisateur { get; set; }
        [Display(Name = "Email"), Required(ErrorMessage = "*"), MaxLength(80, ErrorMessage = "La taille maximale est de 80 caracteres")]
        [DataType(DataType.EmailAddress)]
        public string EmailUtilisateur { get; set; }
        [Display(Name = "Mot de passe"), Required(ErrorMessage = "*"), MaxLength(300, ErrorMessage = "La taille maximale est de 300 caracteres")]
        [DataType(DataType.Password)]
        public string MotDePasseUtilisateur { get; set; }
        [Display(Name = "Matricule"), Required(ErrorMessage = "*"), MaxLength(12, ErrorMessage = "La taille maximale est de 12 caracteres")]
        public string MatriculeUtilisateur { get; set; }
        [Display(Name = "Etat"), Required(ErrorMessage = "*"), MaxLength(10, ErrorMessage = "La taille maximale est de 10 caracteres")]
        public string EtatUtilisateur { get; set; }
    }
}