using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
     public class GvResourceContext : DbContext
    {
        public GvResourceContext()
        {

        }
        public GvResourceContext(DbContextOptions<GvResourceContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=GvResourceProDB; Integrated Security=True;");
        }
        public virtual DbSet<MerchandiseGroup> MerchandiseGroup { get; set; }
        public virtual DbSet<Merchandise> Merchandise { get; set; }
        public virtual DbSet<ExportBillDetail> ExportBillDetail { get; set; }
        public virtual DbSet<ImportBillDetail> ImportBillDetail { get; set; }
        public virtual DbSet<ShipmentLocation> ShipmentLocation { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<ExportBill> ExportBill { get; set; }
        public virtual DbSet<ImportBill> ImportBill { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<StoreHouse> StoreHouse { get; set; }
        public virtual DbSet<Shipment> Shipment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*Merchandise*/
            modelBuilder.Entity<Merchandise>()
                   .Property(x => x.ID)
                   .HasDefaultValueSql("NEWID()");
            /*MerchandiseGroup*/
            modelBuilder.Entity<MerchandiseGroup>()
                    .Property(x => x.ID)
                    .HasDefaultValueSql("NEWID()");
            /*Shipment*/
            modelBuilder.Entity<Shipment>()
                    .Property(x => x.ID)
                    .HasDefaultValueSql("NEWID()");
            /*StoreHouse*/
            modelBuilder.Entity<StoreHouse>()
                    .Property(x => x.ID)
                    .HasDefaultValueSql("NEWID()");
            /*Employee*/
            modelBuilder.Entity<Employee>()
                    .Property(x => x.ID)
                    .HasDefaultValueSql("NEWID()");
            /*ShipmentLocation*/
            modelBuilder.Entity<ShipmentLocation>()
                    .Property(x => x.ID)
                    .HasDefaultValueSql("NEWID()");
            /*Supplier*/
            modelBuilder.Entity<Supplier>()
                    .Property(x => x.ID)
                    .HasDefaultValueSql("NEWID()");
            /*ExportBillDetails*/
            modelBuilder.Entity<ExportBillDetail>()
                    .Property(x => x.ID)
                    .HasDefaultValueSql("NEWID()");
            /*ExportBill*/
            modelBuilder.Entity<ExportBill>()
                    .Property(x => x.ID)
                    .HasDefaultValueSql("NEWID()");
            /*ImportBillDetails*/
            modelBuilder.Entity<ImportBillDetail>()
                    .Property(x => x.ID)
                    .HasDefaultValueSql("NEWID()");
            /*ImportBill*/
            modelBuilder.Entity<ImportBill>()
                    .Property(x => x.ID)
                    .HasDefaultValueSql("NEWID()");
        }
    }
}
