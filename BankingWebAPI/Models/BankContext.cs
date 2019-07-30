using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BankingWebAPI.Models
{
    public partial class BankContext : DbContext
    {
        public BankContext()
        {
        }

        public BankContext(DbContextOptions<BankContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BankAccount> BankAccount { get; set; }
        public virtual DbSet<Entry> Entry { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=localhost,1434;Database=Bank;UID=sa;PWD=P@ssword123;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Holder)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.HolderDocument)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .IsUnicode(false);
                entity.Property(e => e.UpdatedPosition)
                    .IsRequired()
                    .HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<Entry>(entity =>
            {
                entity.Property(e => e.OccurenceDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TransactionId)
                    .IsRequired()
                    .IsUnicode(false);

                //entity.HasOne(d => d.Account)
                //    .WithMany(p => p.EntryAccount)
                //    .HasForeignKey(d => d.AccountId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__Entry__AccountId__59063A47");

                //entity.HasOne(d => d.CounterPart)
                //    .WithMany(p => p.EntryCounterPart)
                //    .HasForeignKey(d => d.CounterPartId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__Entry__CounterPa__59FA5E80");
            });
        }
    }
}
