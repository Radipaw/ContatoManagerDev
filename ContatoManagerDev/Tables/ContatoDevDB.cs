using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ContatoManagerDev.Tables
{
    public partial class ContatoDevDB : DbContext
    {
        public ContatoDevDB()
            : base("name=ContatoDevDB")
        {
        }

        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Contatos> Contatos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
