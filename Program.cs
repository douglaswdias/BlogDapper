using Blog;
using Blog.Models;
using Blog.Repositories;
using Blog.Repository;
using Blog.Screens.TagScreens;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

const string connectionString = "server=localhost\\sqlexpress;database=Blog;trusted_connection=True;TrustServerCertificate=True";

Database.Connection = new SqlConnection(connectionString);
Database.Connection.Open();

Load();


Console.ReadKey();
Database.Connection.Close();

static void Load()
{
  Console.Clear();
  Console.WriteLine("Meu Blog");
  Console.WriteLine("----------------------------------------");
  Console.WriteLine("Escolha uma opção");
  Console.WriteLine("----------------------------------------");
  Console.WriteLine("1 - Gestão de Usuários");
  Console.WriteLine("2 - Gestão de Perfil");
  Console.WriteLine("3 - Gestão de Categorias");
  Console.WriteLine("4 - Gestão de Tags");
  Console.WriteLine("5 - Gestão de Perfil/Usuário");
  Console.WriteLine("6 - Gestão de Post/Tag");
  Console.WriteLine("7 - Relatórios");
  Console.WriteLine("----------------------------------------\n");
  var option = short.Parse(Console.ReadLine()!);

  switch (option)
  {
    case 4:
      MenuTagScreen.Load();
      break;
    default: Load(); break;
  }
}



#region CRUD
// static void CreateUser(SqlConnection connection)
// {
//   var user = new User()
//   {
//     Bio = "balta.io",
//     Email = "balta.io@gmail.com",
//     Image = "http://",
//     Name = "balta",
//     PasswordHash = "HASH",
//     Slug = "balta-io"
//   };
//   var repository = new Repository<User>(connection);
//   var users = repository.Get();

// }

// static void ReadUser(SqlConnection connection)
// {
//   var repository = new Repository<User>(connection);
//   var user = repository.Get(1);

//   Console.WriteLine(user.Name);
// }

// static void ReadUsers(SqlConnection connection)
// {
//   var repository = new UserRepository(connection);
//   var users = repository.GetWithRoles();

//   foreach (var user in users)
//   {
//     Console.WriteLine(user.Name);
//     foreach (var role in user.Roles)
//     {
//       Console.WriteLine($"- {role.Name}");
//     }
//   }
// }

// static void ReadRole(SqlConnection connection)
// {
//   var repository = new Repository<Role>(connection);
//   var role = repository.Get(1);

//   Console.WriteLine(role.Name);
// }

// static void ReadRoles(SqlConnection connection)
// {
//   var repository = new Repository<Role>(connection);
//   var roles = repository.Get();

//   foreach (var role in roles)
//   {
//     Console.WriteLine(role.Name);
//   }
// }

// static void ReadTag(SqlConnection connection)
// {
//   var repository = new Repository<Tag>(connection);
//   var tag = repository.Get(1);

//   Console.WriteLine(tag.Name);
// }

// static void ReadTags(SqlConnection connection)
// {
//   var repository = new Repository<Tag>(connection);
//   var tags = repository.Get();

//   foreach (var tag in tags)
//   {
//     Console.WriteLine(tag.Name);
//   }
// }

// static void UPdateUser()
// {
//   var user = new User()
//   {
//     Id = 2,
//     Bio = "balta.io",
//     Email = "balta.io@gmail.com",
//     Image = "http://",
//     Name = "balta update",
//     PasswordHash = "HASH",
//     Slug = "balta-io"
//   };
//   using(var connection = new SqlConnection(connectionString))
//   {
//     connection.Update<User>(user);

//       Console.WriteLine("Usuario Atualizado.");
//   }
// }

// static void DeleteUser()
// {
//   using(var connection = new SqlConnection(connectionString))
//   {
//     var user = connection.Get<User>(2);
//     connection.Delete<User>(user);
//     Console.WriteLine("Usuario Apagado.");
//   }
// }
#endregion