using Data.BaseRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Model
{
    public class ImportBillDetail : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? ID { get; set; }
        public string ImportBillDetailsCode { get; set; }
        public string ImportBillDetailsName { get; set; }
        public string ImportBillDetailsDescription { get; set; }
        public double ImportBillDetailsAmount { get; set; }
        public double ImportBillDetailsTotal { get; set; }
        public DateTime? DateImportBillDetails { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public Guid? EmployeeID { get; set; }
        public Guid? ImportBillID { get; set; }
        public bool? IsDelete { get; set; }
        [ForeignKey("ImportBillID")]
        public virtual ImportBill ImportBill { get; set; }
    }
}
