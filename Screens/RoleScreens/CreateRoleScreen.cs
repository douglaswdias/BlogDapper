using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.RoleScreens
{
  public static class CreateRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Novo Perfil");
      Console.WriteLine("----------------------------------------");
      Console.Write("Nome: ");
      var name = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();
      Create (new Role
      {
        Name = name,
        Slug = slug
      });
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuRoleScreen.Load();
    }

    public static void Create(Role role)
    {
      try
      {
        var repository = new Repository<Role>(Database.Connection);
        repository.Create(role);
        Console.WriteLine("Perfil Cadastrado");
      }
      catch(Exception ex)
      {
        Console.WriteLine("Erro ao Cadastrar Perfil");
        Console.WriteLine(ex);
      }
    }
  }
}