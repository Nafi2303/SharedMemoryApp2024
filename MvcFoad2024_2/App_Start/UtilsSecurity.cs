using MvcFoad2024_2.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFoad2024_2.App_Start
{
    public class UtilsSecurity
    {
        bdMemorySharedContext db = new bdMemorySharedContext();


        public bool AddProfil(string Code, string Libelle)
        {
            try
            {
                Profil p = new Profil();
                p.CodeProfil = Code;
                p.LibelleProfil = Libelle;
                db.profils.Add(p);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}