using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace CoffeeShop.Domain
{
    public interface IBaseRepository
    {
        Task<MySqlTransaction> BeginTransaction();
    }
    public interface IBaseRepository<TEntity> : IBaseRepository
    {
    }
}
