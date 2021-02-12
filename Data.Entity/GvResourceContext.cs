using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
    public class GvResourceContext : DbContext
    {
        public GvResourceContext(DbContextOptions<GvResourceContext> options)
            : base(options)
        {
        }
        public DbSet<MerchandiseGroup> MerchandiseGroups { get; set; }
        public DbSet<Merchandise> Merchandises { get; set; }
        public DbSet<ExportBillDetail> ExportBillDetails { get; set; }
        public DbSet<ImportBillDetail> ImportBillDetails { get; set; }
        public DbSet<ShipmentLocation> ShipmentLocations { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ExportBill> ExportBills { get; set; }
        public DbSet<ImportBill> ImportBills { get; set; }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Receipt> Receipt { get; set; }
        public DbSet<StoreHouse> StoreHouses { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

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
