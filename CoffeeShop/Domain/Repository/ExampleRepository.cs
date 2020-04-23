using Dapper;
using CoffeeShop.Domain.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Domain.Repository
{
    public class ExampleRepository : BaseRepository<FoodEntity>,IExampleRepository
    {
        public ExampleRepository(MySqlConnection connection) : base(connection)
        {
        }
        public async Task<List<FoodEntity>> GetAll()
        {
            var sp = new StringBuilder(@"
                SELECT
                    Id
                    , Name
                FROM food
            ");

            var result = await Connection.QueryAsync<FoodEntity>(sp.ToString());
            return result.ToList();
        }

    }
}
