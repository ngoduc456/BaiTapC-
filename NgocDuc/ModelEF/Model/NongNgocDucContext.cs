using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ModelEF.Model
{
    public partial class NongNgocDucContext : DbContext
    {
        public NongNgocDucContext()
            : base("name=NongNgocDucContext")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<UserAccount> UserAccount { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.IDCtg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.NameCtg)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.IDpr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.IDCtg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.NamePr)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.Mk)
                .IsUnicode(false);
        }
    }
}
