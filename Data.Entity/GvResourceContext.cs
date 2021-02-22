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
         DbSet<MerchandiseGroup> MerchandiseGroups { get; set; }
         DbSet<Merchandise> Merchandises { get; set; }
         DbSet<ExportBillDetail> ExportBillDetails { get; set; }
         DbSet<ImportBillDetail> ImportBillDetails { get; set; }
         DbSet<ShipmentLocation> ShipmentLocations { get; set; }
         DbSet<Supplier> Suppliers { get; set; }
         DbSet<ExportBill> ExportBills { get; set; }
         DbSet<ImportBill> ImportBills { get; set; }
         DbSet<Employee> Employees { get; set; }
        // DbSet<Receipt> Receipt { get; set; }
         DbSet<StoreHouse> StoreHouses { get; set; }
         DbSet<Shipment> Shipments { get; set; }

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
