using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Model
{
    public class Merchandise //Hàng hóa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? ID { get; set; }
        public string MerchandiseCode { get; set; }
        public string MerchandiseName { get; set; }
        public string MerchandiseDescription { get; set; }
        public double UnitPrice { get; set; }
        public double QuantityInStock { get; set; }
        public string AttachedFiles { get; set; }
        public string AttachmentImage { get; set; }
        public Guid? MerchandiseGroupID { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public bool? IsDelete { get; set; }
        [ForeignKey("MerchandiseGroupID")]
        public virtual MerchandiseGroup MerchandiseGroup { get; set; }
    }
}
