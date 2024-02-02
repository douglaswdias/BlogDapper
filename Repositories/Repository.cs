using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repository
{
  public class Repository<T> where T : class
  {
    readonly SqlConnection _connection;

    public Repository(SqlConnection connection) => _connection = connection;
    public IEnumerable<T> Get() => _connection.GetAll<T>();
  }
}