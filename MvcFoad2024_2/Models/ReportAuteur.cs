using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFoad2024_2.Models
{
    public class ReportAuteur
    {
        public int Anciennete { get; set; }
        public string NomUtilisateur { get; set; }
        public string PrenomUtilisateur { get; set; }
        public string TelUtilisateur { get; set; }
        public string EmailUtilisateur { get; set; }
        public string MatriculeUtilisateur { get; set; }
        public string EtatUtilisateur { get; set; }

    }
}