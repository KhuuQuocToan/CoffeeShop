using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace CoffeeShop.Domain
{
    public class BaseRepository : IBaseRepository
    {
        public MySqlConnection Connection { get; private set; }

        /// <summary>
        /// Database transaction
        /// </summary>
        public MySqlTransaction Transaction { get; private set; }

        public BaseRepository(MySqlConnection connection)
        {
            // Init class name
            // ClassName = GetType().Name;
            Connection = connection;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="connection">MySqlConnection</param>
        public BaseRepository(MySqlTransaction transaction)
        {
            // Init class name
            // ClassName = GetType().Name;
            Transaction = transaction;
            Connection = Transaction.Connection;
        }


        public Task<MySqlTransaction> BeginTransaction()
        {
            throw new NotImplementedException();
        }

    }
    public abstract class BaseRepository<TEntity> : BaseRepository, IBaseRepository<TEntity>
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="connection">MySqlConnection</param>
        public BaseRepository(MySqlConnection connection) : base(connection)
        {
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="transaction">MySqlTransaction</param>
        public BaseRepository(MySqlTransaction transaction) : base(transaction)
        {
        }
    }
}
