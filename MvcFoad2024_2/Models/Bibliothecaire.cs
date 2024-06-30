using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcFoad2024_2.Models;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFoad2024_2
{
    [Table("td_bibliothecaire")]
    public class Bibliothecaire:Utilisateur
    {
       public virtual ICollection<Memoire> Memoires { get; set; }
    }
}