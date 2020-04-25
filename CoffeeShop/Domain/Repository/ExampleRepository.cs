using Dapper;
using CoffeeShop.Domain.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using CoffeeShop.Containts;
using System.ComponentModel.DataAnnotations;
using System.Data;

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
                    food.Id
                    , food.Name
                    , food.Amount
                    , food.Price
                    , food.CreatedByUserId
                    , food.LastUpdatedByUserId
                    , food.CreatedDate
                    , food.LastUpdatedDate
                    , food.Status
                    , staff.Id
                    , staff.UserName

                FROM food 
                INNER JOIN staff
                ON food.CreatedByUserId = staff.Id
                WHERE food.IsDeleted = @IsDeleted
                ORDER BY food.CreatedDate DESC
            ");
            var param = new DynamicParameters();
            param.Add("IsDeleted", FlagConts.DeletedFlag.NOT_DELETED, DbType.Int32);
            var result = await Connection.QueryAsync<FoodEntity,StaffEntity, FoodEntity>(sp.ToString(),
                                (foodEntity, staffEntity) =>
                                {
                                    foodEntity.StaffEntity = staffEntity;
                                    return foodEntity;
                                }, param,
                                splitOn:"Id");
            return result.ToList();
        }

    }
}
