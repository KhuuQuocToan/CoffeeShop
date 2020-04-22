using CoffeeShop.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeShop.Repository.Food
{
    public interface IFoodRepository
    {
        Task<List<FoodEntity>> GetAllEntity();
    }
}
