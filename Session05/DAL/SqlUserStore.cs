using System;
using BLL;
using BLL.Contracts;

namespace DAL
{
    public class SqlUserStore : IUserStore
    {
        private readonly IDatabaseConnection _connection;
        public SqlUserStore(IDatabaseConnection connection)
        {
            _connection = connection;
        }
        public void Add(UserDto userDto)
        {
            //....
        }
    }

    public interface IDatabaseConnection {  }
    public class SqlConnection : IDatabaseConnection
    {
        public SqlConnection()
        {
            
        }
    }
}
