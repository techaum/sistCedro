using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace sistCedro.Models
{
    public class ContextoPrato : DbContext
    {
        public DbSet<Prato> Prato { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // other code 
            Database.SetInitializer<ContextoPrato>(null);
            // more code
        }
    }
}