using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleDealer.Models;


namespace VehicleDealerDal.cs
{
    class VehicleRepo
    {
        private VechileDealerContext context;
        public VehicleRepo()
        {
            context = new VechileDealerContext();
        }

        public Vehicle GetVehicleById(int VehicleId)
        {

            Vehicle Vehicle = context.Vehicle.Where(a => a.VehicleId == VehicleId).FirstOrDefault();
            return Vehicle;
        }
        public void InsertVehicle(Vehicle Vehicle)
        {
            context.Vehicle.Add(Vehicle);
            context.SaveChanges();
        }
        public void UpdateVehicle(Vehicle Vehicle)
        {
            Vehicle VehicleToUpdate = context.Vehicle.Where(a => a.VehicleId == Vehicle.VehicleId).FirstOrDefault();
           
            context.SaveChanges();

        }
        public void DeleteVehicle(Vehicle Vehicle)
        {
            context.Vehicle.Remove(Vehicle);
            context.SaveChanges();
        }
    }
}
