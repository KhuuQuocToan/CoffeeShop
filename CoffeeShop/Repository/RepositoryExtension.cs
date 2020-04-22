using CoffeeShop.Repository.Food;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShop.Repository
{
    public static class RepositoryExtension
    {
        public static void UseRepositoryExtension (this IServiceCollection services)
        {
            services.AddTransient<IFoodRepository, FoodRepository>();
        }
    }
}
