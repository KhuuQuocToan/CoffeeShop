using CoffeeShop.Containts;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace CoffeeShop.Repository
{
    public class ConnectionRepository
    {
        public static IDbConnection ConnectionDatabase (IConfiguration configuration)
        {
            return new MySqlConnection(configuration.GetConnectionString(AppsettingConst.MY_CONNECTION));
        }
    }
}
