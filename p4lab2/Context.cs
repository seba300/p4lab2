using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace p4lab2
{
    public class Context:DbContext
    {
        public DbSet<Zajecia> Zajecias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=EFCF;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        #region fluenty
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Zajecia>()
        //        .HasKey(x => x.Id);
        //    modelBuilder
        //        .Entity<Zajecia>()
        //        .Property(x => x.Nazwa)
        //        .IsRequired();

        //}
        #endregion
    }
}
