using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Entity.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
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
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MerchandiseGroups",
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
                    table.PrimaryKey("PK_MerchandiseGroups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentLocations",
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
                    table.PrimaryKey("PK_ShipmentLocations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StoreHouses",
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
                    table.PrimaryKey("PK_StoreHouses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
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
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ExportBills",
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
                    table.PrimaryKey("PK_ExportBills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExportBills_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImportBills",
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
                    table.PrimaryKey("PK_ImportBills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ImportBills_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Merchandises",
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
                    table.PrimaryKey("PK_Merchandises", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Merchandises_MerchandiseGroups_MerchandiseGroupID",
                        column: x => x.MerchandiseGroupID,
                        principalTable: "MerchandiseGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImportBillDetails",
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
                    table.PrimaryKey("PK_ImportBillDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ImportBillDetails_ImportBills_ImportBillID",
                        column: x => x.ImportBillID,
                        principalTable: "ImportBills",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shipments",
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
                    table.PrimaryKey("PK_Shipments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shipments_ImportBillDetails_ImportBillDetailsID",
                        column: x => x.ImportBillDetailsID,
                        principalTable: "ImportBillDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipments_Merchandises_MerchandiseID",
                        column: x => x.MerchandiseID,
                        principalTable: "Merchandises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipments_ShipmentLocations_ShipmentLocationID",
                        column: x => x.ShipmentLocationID,
                        principalTable: "ShipmentLocations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipments_StoreHouses_StoreHouseID",
                        column: x => x.StoreHouseID,
                        principalTable: "StoreHouses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipments_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExportBillDetails",
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
                    table.PrimaryKey("PK_ExportBillDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExportBillDetails_ExportBills_ExportBillID",
                        column: x => x.ExportBillID,
                        principalTable: "ExportBills",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExportBillDetails_Shipments_ShipmentID",
                        column: x => x.ShipmentID,
                        principalTable: "Shipments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExportBillDetails_ExportBillID",
                table: "ExportBillDetails",
                column: "ExportBillID");

            migrationBuilder.CreateIndex(
                name: "IX_ExportBillDetails_ShipmentID",
                table: "ExportBillDetails",
                column: "ShipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ExportBills_EmployeeID",
                table: "ExportBills",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ImportBillDetails_ImportBillID",
                table: "ImportBillDetails",
                column: "ImportBillID");

            migrationBuilder.CreateIndex(
                name: "IX_ImportBills_EmployeeID",
                table: "ImportBills",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Merchandises_MerchandiseGroupID",
                table: "Merchandises",
                column: "MerchandiseGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_ImportBillDetailsID",
                table: "Shipments",
                column: "ImportBillDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_MerchandiseID",
                table: "Shipments",
                column: "MerchandiseID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_ShipmentLocationID",
                table: "Shipments",
                column: "ShipmentLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_StoreHouseID",
                table: "Shipments",
                column: "StoreHouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_SupplierID",
                table: "Shipments",
                column: "SupplierID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExportBillDetails");

            migrationBuilder.DropTable(
                name: "ExportBills");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "ImportBillDetails");

            migrationBuilder.DropTable(
                name: "Merchandises");

            migrationBuilder.DropTable(
                name: "ShipmentLocations");

            migrationBuilder.DropTable(
                name: "StoreHouses");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "ImportBills");

            migrationBuilder.DropTable(
                name: "MerchandiseGroups");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
