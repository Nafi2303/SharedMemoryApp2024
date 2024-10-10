using MvcFoad2024_2.Models;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MvcFoad2024_2.App_Start
{
    public class Util
    {
        bdMemorySharedContext db = new bdMemorySharedContext();

        /// <summary>
        /// Cette methode permet de logger les erreurs dans la table Td_Erreur de la base de données.
        /// </summary>
        /// <param name="TitreErreur">C'est le nom de la classe - le nom de la methode</param>
        /// <param name="erreur">Message d'Erreur</param>
        public void WriteDataError(string TitreErreur, string erreur)
        {
            try
            {
                Td_Erreur log = new Td_Erreur();
                log.DateErreur = DateTime.Now;
                log.DescriptionErreur = erreur.Length > 2000 ? erreur.Substring(0, 1000) : erreur;
                log.TitreErreur = TitreErreur;
                db.td_Erreurs.Add(log);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }
        }

        /// <summary>
        /// cette methode enregistre les logs au niveau du systeme d'exploitation
        /// </summary>
        /// <param name="libelle">Nom classe - Nom methode</param>
        /// <param name="erreur">Message d'erreur</param>
        public static void WriteLogSystem(string libelle, string erreur)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "MvcFoad2024_2";
                eventLog.WriteEntry(string.Format("date: {0}, libelle: {1}, description {2}", DateTime.Now, libelle, erreur), EventLogEntryType.Information, 101, 1);
            }
        }
    }
}