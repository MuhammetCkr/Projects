using FoodSite.Business.Abstract;
using FoodSite.Data.Abstract;
using FoodSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Business.Concrete
{
    public class MaterialManager : IMaterialService
    {
        private IMaterialRepository _materialRepository;

        public MaterialManager(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }
    }
}
