using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFoad2024_2.Models
{
    public class Td_Erreur
    {
        [Key]
        public int ID { get; set; }

        public DateTime DateErreur { get; set; }

        [Required, MaxLength(2000)]
        public string DescriptionErreur { get; set; }

        [Required, MaxLength(200)]
        public string TitreErreur { get; set; }
    }
}