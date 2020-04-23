using CoffeeShop.Domain.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShop.Domain
{
    public static class RepositoryExtention
    {
        /// <summary>
        /// Register respositories
        /// </summary>
        /// <param name="services"></param>
        public static void UseRepositoryExtension(this IServiceCollection services)
        {
            // Commons
            services.AddTransient<IExampleRepository, ExampleRepository>();
        }
    }
}
