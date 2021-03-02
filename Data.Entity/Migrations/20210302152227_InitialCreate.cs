using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Entity.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachedFiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MerchandiseGroup",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    MerchandiseGroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchandiseGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchandiseGroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachedFiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchandiseGroup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentLocation",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ShipmentLocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipmentLocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipmentLocationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfFloors = table.Column<int>(type: "int", nullable: false),
                    NumberOfRows = table.Column<int>(type: "int", nullable: false),
                    NumberOfColumns = table.Column<int>(type: "int", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentLocation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StoreHouse",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    StoreHouseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreHouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreHouseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfFloors = table.Column<int>(type: "int", nullable: false),
                    NumberOfRows = table.Column<int>(type: "int", nullable: false),
                    NumberOfColumns = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreHouse", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    SupplierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierPhone = table.Column<int>(type: "int", nullable: false),
                    SupplierMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachedFiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ExportBill",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ExportBillCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportBillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportBillDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateExportBill = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportBill", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExportBill_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImportBill",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ImportBillCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportBillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportBillDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateImportBill = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportBill", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ImportBill_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Merchandise",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    MerchandiseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchandiseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchandiseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    QuantityInStock = table.Column<double>(type: "float", nullable: false),
                    AttachedFiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchandiseGroupID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchandise", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Merchandise_MerchandiseGroup_MerchandiseGroupID",
                        column: x => x.MerchandiseGroupID,
                        principalTable: "MerchandiseGroup",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImportBillDetail",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ImportBillDetailsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportBillDetailsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportBillDetailsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportBillDetailsAmount = table.Column<double>(type: "float", nullable: false),
                    ImportBillDetailsTotal = table.Column<double>(type: "float", nullable: false),
                    DateImportBillDetails = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImportBillID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportBillDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ImportBillDetail_ImportBill_ImportBillID",
                        column: x => x.ImportBillID,
                        principalTable: "ImportBill",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ShipmentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfManufacture = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShipmentAmount = table.Column<double>(type: "float", nullable: true),
                    ShipmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreHouseID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImportBillDetailsID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShipmentLocationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MerchandiseID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shipment_ImportBillDetail_ImportBillDetailsID",
                        column: x => x.ImportBillDetailsID,
                        principalTable: "ImportBillDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipment_Merchandise_MerchandiseID",
                        column: x => x.MerchandiseID,
                        principalTable: "Merchandise",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipment_ShipmentLocation_ShipmentLocationID",
                        column: x => x.ShipmentLocationID,
                        principalTable: "ShipmentLocation",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipment_StoreHouse_StoreHouseID",
                        column: x => x.StoreHouseID,
                        principalTable: "StoreHouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipment_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExportBillDetail",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ExportBillDetailsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportBillDetailsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportBillDetailsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportBillDetailsAmount = table.Column<double>(type: "float", nullable: false),
                    ExportBillDetailsTotal = table.Column<double>(type: "float", nullable: false),
                    DateExportBillDetails = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShipmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExportBillID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportBillDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExportBillDetail_ExportBill_ExportBillID",
                        column: x => x.ExportBillID,
                        principalTable: "ExportBill",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExportBillDetail_Shipment_ShipmentID",
                        column: x => x.ShipmentID,
                        principalTable: "Shipment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExportBill_EmployeeID",
                table: "ExportBill",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ExportBillDetail_ExportBillID",
                table: "ExportBillDetail",
                column: "ExportBillID");

            migrationBuilder.CreateIndex(
                name: "IX_ExportBillDetail_ShipmentID",
                table: "ExportBillDetail",
                column: "ShipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ImportBill_EmployeeID",
                table: "ImportBill",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ImportBillDetail_ImportBillID",
                table: "ImportBillDetail",
                column: "ImportBillID");

            migrationBuilder.CreateIndex(
                name: "IX_Merchandise_MerchandiseGroupID",
                table: "Merchandise",
                column: "MerchandiseGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_ImportBillDetailsID",
                table: "Shipment",
                column: "ImportBillDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_MerchandiseID",
                table: "Shipment",
                column: "MerchandiseID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_ShipmentLocationID",
                table: "Shipment",
                column: "ShipmentLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_StoreHouseID",
                table: "Shipment",
                column: "StoreHouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_SupplierID",
                table: "Shipment",
                column: "SupplierID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExportBillDetail");

            migrationBuilder.DropTable(
                name: "ExportBill");

            migrationBuilder.DropTable(
                name: "Shipment");

            migrationBuilder.DropTable(
                name: "ImportBillDetail");

            migrationBuilder.DropTable(
                name: "Merchandise");

            migrationBuilder.DropTable(
                name: "ShipmentLocation");

            migrationBuilder.DropTable(
                name: "StoreHouse");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "ImportBill");

            migrationBuilder.DropTable(
                name: "MerchandiseGroup");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
