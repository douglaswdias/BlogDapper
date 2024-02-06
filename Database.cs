using Microsoft.Data.SqlClient;

namespace Blog
{
  public static class Database
  {
    const string connectionString = "server=localhost\\sqlexpress;database=Blog;trusted_connection=True;TrustServerCertificate=True";
    public static SqlConnection Connection = new(connectionString);
  }
}