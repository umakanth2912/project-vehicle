using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace VehicleDealer.Models
{
    public class Dealer
    {
        [Key]
        public int DealerId { get; set; }
        public string DealerName { get; set; }
        public string DealerCity { get; set; }
        public string DealerCountry { get; set; }
        public int DealerPhoneNumber { get; set; }

        public virtual ICollection<Vehicle> Vehcile { get; set; }
    }
}