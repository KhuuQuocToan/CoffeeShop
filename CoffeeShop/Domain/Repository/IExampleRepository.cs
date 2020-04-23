using CoffeeShop.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeShop.Domain.Repository
{
    public interface IExampleRepository
    {
        Task<List<FoodEntity>> GetAll();
    }
}
