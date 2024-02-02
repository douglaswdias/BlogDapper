using Blog.Models;
using Blog.Repositories;
using Blog.Repository;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

const string connectionString = "server=localhost\\sqlexpress;database=Blog;trusted_connection=True;TrustServerCertificate=True";

var connection = new SqlConnection(connectionString);
connection.Open();
// CreateUser();
// ReadUser();
// ReadRoles(connection);
// ReadUsers(connection);
// UPdateUser();
// DeleteUser();
connection.Close();

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

static void ReadUsers(SqlConnection connection)
{
  var repository = new UserRepository(connection);
  var users = repository.Get();

  foreach (var user in users)
  {
    Console.WriteLine(user.Name);
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

static void ReadRoles(SqlConnection connection)
{
  var repository = new RoleRepository(connection);
  var roles = repository.Get();

  foreach (var role in roles)
  {
    Console.WriteLine(role.Name);
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