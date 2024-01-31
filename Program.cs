using Blog.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

const string connectionString = "server=localhost\\sqlexpress;database=Blog;trusted_connection=True;TrustServerCertificate=True";
// CreateUser();
// ReadUser();
// ReadUsers();
// UPdateUser();
DeleteUser();

static void CreateUser()
{
  var user = new User()
  {
    Bio = "balta.io",
    Email = "balta.io@gmail.com",
    Image = "http://",
    Name = "balta",
    PasswordHash = "HASH",
    Slug = "balta-io"
  };
  using(var connection = new SqlConnection(connectionString))
  {
    connection.Insert<User>(user);

      Console.WriteLine("Cadastro Realizado.");
  }
}

static void ReadUsers()
{
  using(var connection = new SqlConnection(connectionString))
  {
    var users = connection.GetAll<User>();

    foreach (var user in users)
    {
      Console.WriteLine(user.Name);
    }
  }
}

static void ReadUser()
{
  using(var connection = new SqlConnection(connectionString))
  {
    var user = connection.Get<User>(1);

      Console.WriteLine(user.Name);
  }
}

static void UPdateUser()
{
  var user = new User()
  {
    Id = 2,
    Bio = "balta.io",
    Email = "balta.io@gmail.com",
    Image = "http://",
    Name = "balta update",
    PasswordHash = "HASH",
    Slug = "balta-io"
  };
  using(var connection = new SqlConnection(connectionString))
  {
    connection.Update<User>(user);

      Console.WriteLine("Usuario Atualizado.");
  }
}

static void DeleteUser()
{
  using(var connection = new SqlConnection(connectionString))
  {
    var user = connection.Get<User>(2);
    connection.Delete<User>(user);
    Console.WriteLine("Usuario Apagado.");
  }
}