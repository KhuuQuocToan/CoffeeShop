using CoffeeShop.Containts;
using CoffeeShop.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Repository.Food
{
    public class FoodRepository : IFoodRepository
    {
        private readonly IConfiguration _config;
        public FoodRepository(IConfiguration configuration)
        {
            _config = configuration;
        }
        public async Task<List<FoodEntity>> GetAllEntity()
        {
            try
            {
            var conn = new MySqlConnection(_config.GetConnectionString(AppsettingConst.MY_CONNECTION));

            }
            catch(Exception ex)
            {

            }
            using (var connection = ConnectionRepository.ConnectionDatabase(_config))
            {
                var query = new StringBuilder(@"
                    SELECT * 
                    FROM food
                 ");
                connection.Open();
                var result = await connection.QueryAsync<FoodEntity>(query.ToString());
                return result.ToList();
            }
        }
    }
}
