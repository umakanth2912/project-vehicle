using System;
using System.Collections.Generic;
using System.Linq;
using VehicleDealer.Models;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDealerDal.cs
{
    class BrandRepo
    {
        private VechileDealerContext context;
        public BrandRepo()
        {
            context = new VechileDealerContext();
        }

        public Brand GetDealerById(int BrandId)
        {

            Brand Brand = context.Brand.Where(a => a.BrandId == BrandId).FirstOrDefault();
            return Brand;
        }
        public void InsertBrand(Brand Brand)
        {
            context.Brand.Add(Brand);
            context.SaveChanges();
        }
        public void UpdateBrand(Brand Brand)
        {
            Brand BrandToUpdate = context.Brand.Where(a => a.BrandId == Brand.BrandId).FirstOrDefault();
            BrandToUpdate.BrandName = Brand.BrandName;
            
            context.SaveChanges();

        }
        public void DeleteBrand(Brand Brand)
        {
            context.Brand.Remove(Brand);
            context.SaveChanges();
        }
    }
}
