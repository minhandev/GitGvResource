using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Data.Entity;

namespace Data.Model
{
    public class ExportBillDetail : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? ID { get; set; }
        public string ExportBillDetailsCode { get; set; }
        public string ExportBillDetailsName { get; set; }
        public string ExportBillDetailsDescription { get; set; }
        public double ExportBillDetailsAmount { get; set; }
        public double ExportBillDetailsTotal { get; set; }
        public DateTime? DateExportBillDetails { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public Guid? EmployeeID { get; set; }
        public Guid? ShipmentID { get; set; }
        public Guid? ExportBillID { get; set; }
        public bool? IsDelete { get; set; }
        [ForeignKey("ShipmentID")]
        public virtual Shipment Shipment { get; set; }
        [ForeignKey("ExportBillID")]
        public virtual ExportBill ExportBill { get; set; }
    }
}
