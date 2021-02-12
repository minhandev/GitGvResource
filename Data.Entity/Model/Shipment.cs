using Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Model
{
    public class Shipment : BaseEntity//Lô hàng
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? ID { get; set; }
        public string ShipmentCode { get; set; }
        public string ShipmentName { get; set; }
        public DateTime? DateOfManufacture { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public Double? ShipmentAmount { get; set; }
        public string ShipmentDescription { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public Guid? StoreHouseID { get; set; }//Nhà kho
        public Guid? ImportBillDetailsID { get; set; }//Phiếu nhập
        public Guid? ShipmentLocationID { get; set; }//Vị trí lô hàng
        public Guid? SupplierID { get; set; }//Nhà cung cấp      
        public Guid? MerchandiseID { get; set; }//Hàng hóa  
        public bool? IsDelete { get; set; }
        [ForeignKey("ImportBillDetailsID")]
        public virtual ImportBillDetail ImportBillDetails { get; set; }
        [ForeignKey("ShipmentLocationID")]
        public virtual ShipmentLocation ShipmentLocation { get; set; }
        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }
        [ForeignKey("MerchandiseID")]
        public virtual Merchandise Merchandise { get; set; }
        [ForeignKey("StoreHouseID")]
        public virtual StoreHouse StoreHouse { get; set; }
    }
}
