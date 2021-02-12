using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Data.Entity;

namespace Data.Model
{
    public class ExportBill : BaseEntity //Phiếu xuất
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? ID { get; set; }
        public string ExportBillCode { get; set; }
        public string ExportBillName { get; set; }
        public string ExportBillDescription { get; set; }
        public DateTime? DateExportBill { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public Guid? EmployeeID { get; set; }
        public bool? IsDelete { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }
    }
}
