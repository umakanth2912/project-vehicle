using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VehicleDealer.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        
        public int DealerId { get; set; }
        [ForeignKey("DealerId")]
        public virtual Dealer Dealer { get; set; }
        public virtual ICollection<Brand> Brand { get; set; }
    }
}