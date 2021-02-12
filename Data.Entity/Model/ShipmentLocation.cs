using Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Model
{
    public class ShipmentLocation : BaseEntity//Vị trí lô hàng
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? ID { get; set; }
        public string ShipmentLocationCode { get; set; }
        public string ShipmentLocationName { get; set; }
        public string ShipmentLocationDescription { get; set; }
        public int NumberOfFloors { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public bool? IsDelete { get; set; }
    }
}
