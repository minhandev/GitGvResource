using Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Model
{
    public class MerchandiseGroup : BaseEntity//Nhóm hàng hóa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? ID { get; set; }
        public string MerchandiseGroupCode { get; set; }
        public string MerchandiseGroupName { get; set; }
        public string MerchandiseGroupDescription { get; set; }
        public string AttachedFiles { get; set; }
        public string AttachmentImage { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public bool? IsDelete { get; set; }
    }
}
