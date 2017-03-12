using System;
using System.Collections.Generic;
using System.Linq;
using VehicleDealer.Models;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDealerDal.cs
{
    class ModeelsRepo
    {
        private VechileDealerContext context;
        public ModeelsRepo()
        {
            context = new VechileDealerContext();
        }

        public Modeels GetDealerById(int ModelId)
        {

            Modeels Model = context.Modeels.Where(a => a.ModelId == ModelId).FirstOrDefault();
            return Model;
        }
        public void InsertModel(Modeels Model)
        {
            context.Modeels.Add(Model);
            context.SaveChanges();
        }
        public void UpdateModel(Modeels Model)
        {
            Modeels ModelToUpdate = context.Modeels.Where(a => a.ModelId == a.ModelId).FirstOrDefault();
            ModelToUpdate.ModelName = Model.ModelName;
            ModelToUpdate.ModelColor = Model.ModelColor;
            ModelToUpdate.ModelYear = Model.ModelYear;
            

            context.SaveChanges();

        }
        public void DeleteModel(Modeels Model)
        {
            context.Modeels.Remove(Model);
            context.SaveChanges();
        }
    }
}
