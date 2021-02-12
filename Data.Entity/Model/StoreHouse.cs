using Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Model
{
    public class StoreHouse : BaseEntity //Nhà kho
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? ID { get; set; }
        public string StoreHouseCode { get; set; }
        public string StoreHouseName { get; set; }
        public string StoreHouseDescription { get; set; }
        public int NumberOfFloors { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        public bool? IsDelete { get; set; }

    }
}
