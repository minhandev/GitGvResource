﻿// <auto-generated />
using System;
using Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Entity.Migrations
{
    [DbContext(typeof(GvResourceContext))]
    partial class GvResourceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Data.Model.Employee", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("AttachedFiles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AttachmentImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Data.Model.ExportBill", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateExportBill")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExportBillCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExportBillDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExportBillName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("UserCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("ExportBills");
                });

            modelBuilder.Entity("Data.Model.ExportBillDetail", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateExportBillDetails")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("ExportBillDetailsAmount")
                        .HasColumnType("float");

                    b.Property<string>("ExportBillDetailsCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExportBillDetailsDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExportBillDetailsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ExportBillDetailsTotal")
                        .HasColumnType("float");

                    b.Property<Guid?>("ExportBillID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ShipmentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ExportBillID");

                    b.HasIndex("ShipmentID");

                    b.ToTable("ExportBillDetails");
                });

            modelBuilder.Entity("Data.Model.ImportBill", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateImportBill")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImportBillCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportBillDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportBillName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("UserCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("ImportBills");
                });

            modelBuilder.Entity("Data.Model.ImportBillDetail", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateImportBillDetails")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("ImportBillDetailsAmount")
                        .HasColumnType("float");

                    b.Property<string>("ImportBillDetailsCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportBillDetailsDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportBillDetailsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ImportBillDetailsTotal")
                        .HasColumnType("float");

                    b.Property<Guid?>("ImportBillID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("UserCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ImportBillID");

                    b.ToTable("ImportBillDetails");
                });

            modelBuilder.Entity("Data.Model.Merchandise", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("AttachedFiles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AttachmentImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("MerchandiseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchandiseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MerchandiseGroupID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MerchandiseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("QuantityInStock")
                        .HasColumnType("float");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.Property<string>("UserCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MerchandiseGroupID");

                    b.ToTable("Merchandises");
                });

            modelBuilder.Entity("Data.Model.MerchandiseGroup", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("AttachedFiles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AttachmentImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("MerchandiseGroupCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchandiseGroupDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchandiseGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MerchandiseGroups");
                });

            modelBuilder.Entity("Data.Model.Shipment", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfManufacture")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImportBillDetailsID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<Guid?>("MerchandiseID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("ShipmentAmount")
                        .HasColumnType("float");

                    b.Property<string>("ShipmentCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipmentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ShipmentLocationID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShipmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StoreHouseID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SupplierID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ImportBillDetailsID");

                    b.HasIndex("MerchandiseID");

                    b.HasIndex("ShipmentLocationID");

                    b.HasIndex("StoreHouseID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("Data.Model.ShipmentLocation", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfColumns")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfFloors")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfRows")
                        .HasColumnType("int");

                    b.Property<string>("ShipmentLocationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipmentLocationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipmentLocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ShipmentLocations");
                });

            modelBuilder.Entity("Data.Model.StoreHouse", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfColumns")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfFloors")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfRows")
                        .HasColumnType("int");

                    b.Property<string>("StoreHouseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreHouseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreHouseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("StoreHouses");
                });

            modelBuilder.Entity("Data.Model.Supplier", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("AttachedFiles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AttachmentImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("SupplierAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SupplierPhone")
                        .HasColumnType("int");

                    b.Property<string>("UserCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Data.Model.ExportBill", b =>
                {
                    b.HasOne("Data.Model.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Data.Model.ExportBillDetail", b =>
                {
                    b.HasOne("Data.Model.ExportBill", "ExportBill")
                        .WithMany()
                        .HasForeignKey("ExportBillID");

                    b.HasOne("Data.Model.Shipment", "Shipment")
                        .WithMany()
                        .HasForeignKey("ShipmentID");

                    b.Navigation("ExportBill");

                    b.Navigation("Shipment");
                });

            modelBuilder.Entity("Data.Model.ImportBill", b =>
                {
                    b.HasOne("Data.Model.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Data.Model.ImportBillDetail", b =>
                {
                    b.HasOne("Data.Model.ImportBill", "ImportBill")
                        .WithMany()
                        .HasForeignKey("ImportBillID");

                    b.Navigation("ImportBill");
                });

            modelBuilder.Entity("Data.Model.Merchandise", b =>
                {
                    b.HasOne("Data.Model.MerchandiseGroup", "MerchandiseGroup")
                        .WithMany()
                        .HasForeignKey("MerchandiseGroupID");

                    b.Navigation("MerchandiseGroup");
                });

            modelBuilder.Entity("Data.Model.Shipment", b =>
                {
                    b.HasOne("Data.Model.ImportBillDetail", "ImportBillDetails")
                        .WithMany()
                        .HasForeignKey("ImportBillDetailsID");

                    b.HasOne("Data.Model.Merchandise", "Merchandise")
                        .WithMany()
                        .HasForeignKey("MerchandiseID");

                    b.HasOne("Data.Model.ShipmentLocation", "ShipmentLocation")
                        .WithMany()
                        .HasForeignKey("ShipmentLocationID");

                    b.HasOne("Data.Model.StoreHouse", "StoreHouse")
                        .WithMany()
                        .HasForeignKey("StoreHouseID");

                    b.HasOne("Data.Model.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierID");

                    b.Navigation("ImportBillDetails");

                    b.Navigation("Merchandise");

                    b.Navigation("ShipmentLocation");

                    b.Navigation("StoreHouse");

                    b.Navigation("Supplier");
                });
#pragma warning restore 612, 618
        }
    }
}
