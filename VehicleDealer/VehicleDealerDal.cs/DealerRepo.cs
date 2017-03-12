using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleDealer.Models;

namespace VehicleDealerDal.cs
{
    class DealerRepo
    {
        private VechileDealerContext context;
        public DealerRepo()
        {
            context = new VechileDealerContext();
        }

        public Dealer GetDealerById(int DealerId)
        {

            Dealer Dealer = context.Dealer.Where(a => a.DealerId == DealerId).FirstOrDefault();
            return Dealer;
        }
        public void InsertDealer(Dealer Dealer)
        {
            context.Dealer.Add(Dealer);
            context.SaveChanges();
        }
        public void UpdateDealer(Dealer Dealer)
        {
            Dealer DealerToUpdate = context.Dealer.Where(a => a.DealerId == Dealer.DealerId).FirstOrDefault();
            DealerToUpdate.DealerName = Dealer.DealerName;
            DealerToUpdate.DealerCity = Dealer.DealerCity;
            DealerToUpdate.DealerCountry = Dealer.DealerCountry;
            DealerToUpdate.DealerPhoneNumber = Dealer.DealerPhoneNumber;
            context.SaveChanges();

        }
        public void DeleteDealer(Dealer Dealer)
        {
            context.Dealer.Remove(Dealer);
            context.SaveChanges();
        }
    }
}
