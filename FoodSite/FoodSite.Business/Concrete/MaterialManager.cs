using FoodSite.Business.Abstract;
using FoodSite.Data.Abstract;
using FoodSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Business.Concrete
{
    public class MaterialManager : IMaterialService
    {
        private readonly IMaterialRepository _materialRepository;

        public MaterialManager(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }

        public async Task<List<Material>> GetAllAsync(Expression<Func<Material, bool>> expression)
        {
            return await _materialRepository.GetAllAsync(expression);
        }

        public async Task<List<Material>> GetAllAsync()
        {
            return await _materialRepository.GetAllAsync();
        }
    }
}
