using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcFoad2024_2.Models
{
    public class bdMemorySharedContext:DbContext
    {
        //creation du constructeur public
        public bdMemorySharedContext():base("connSharedMemory") 
        {

        }

        public DbSet<Memoire> memoires { get; set; }

        public DbSet<Utilisateur> utilisateurs { get; set; }

        public DbSet<Commentaire> commentaires { get; set; }

        public DbSet<Expert> experts { get; set; }

        public DbSet<Auteur> auteurs { get; set; }

        public DbSet<Document> documents { get; set; }

        public DbSet<MemoireAuteur> memoireAuteurs { get; set; }

        public DbSet<Employee> employee { get; set; }

        public DbSet<Lecteur> lecteurs { get; set; }
    }
}